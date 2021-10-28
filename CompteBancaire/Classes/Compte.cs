using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CompteBancaire.Classes
{
    public class Compte
    {
        private decimal solde;
        private int numero;
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;
        public event Action<int, decimal> ADecouvert;

        //private static int compteur = 0;
        private Client client;
        private List<Operation> operations;

        public Compte()
        {
            //numero = ++compteur;
            Operations = new List<Operation>();
            solde = 0;
        }

        public Compte(decimal s, int n) : this(s)
        {
            solde = s;
            numero = n;
        }

        public Compte(decimal s) : this()
        {
            solde = s;

        }

        public decimal Solde { get => solde;}
        public Client Client { get => client; set => client = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }
        public int Numero { get => numero; }


        public bool Save()
        {
            request = "INSERT INTO compte (solde, clientId) values (@solde, @clientId); SELECT last_insert_id();";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@solde", Solde));
            command.Parameters.Add(new MySqlParameter("@clientId", Client.Id));
            connection.Open();
            numero = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return numero > 0;
        }


        public bool Update()
        {
            request = "UPDATE compte set solde=@solde where id=@id";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@solde", Solde));
            command.Parameters.Add(new MySqlParameter("@id", numero));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        public virtual bool Depot(Operation o)
        {
            if(o.Montant > 0)
            {
                Operations.Add(o);
                if(o.Save(numero))
                {
                    solde += o.Montant;
                    return Update();
                }          
                return false;
            }
            return false;
        }

        public virtual bool Retrait(Operation o)
        {
            if(o.Montant < 0) {
                Operations.Add(o);
                if (o.Save(numero))
                {
                    solde += o.Montant;
                    return Update();
                }         
                if (solde < 0 && ADecouvert != null)
                {
                    ADecouvert(numero, solde);
                }
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            string retour = $"Numero du compte {numero},";
            retour += $"Solde {solde},";
            retour += $"Client {Client}";
            return retour;
        }

        public static Compte GetCompteById(int numero)
        {
            Compte compte = null;
            int clientId = 0;
            request = "SELECT solde, clientId from compte where id=@id";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", numero));
            connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                compte = new Compte(reader.GetDecimal(0), numero);
                clientId = reader.GetInt32(1);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            if(compte != null)
            {
                compte.Client = Client.GetClient(clientId);

                compte.Operations = Operation.GetOperations(compte.Numero);
            }
            return compte;
        }
    }
}
