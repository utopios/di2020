using System;
using MySql.Data.MySqlClient;

namespace CompteBancaire.Classes
{
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id { get => id;  }
        public Client(string n, string p, string t)
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
        }

        public Client(int i, string n, string p, string t):this(n, p, t)
        {
            id = i;
            
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prénom : {Prenom}, Tel : {Telephone}";
        }

        public bool Save()
        {
            
            request = "INSERT INTO client (nom, prenom, telephone) values(@nom, @prenom, @telephone); select last_insert_id()";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nom", Nom));
            command.Parameters.Add(new MySqlParameter("@prenom", Prenom));
            command.Parameters.Add(new MySqlParameter("@telephone", Telephone));
            connection.Open();
            id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public static Client GetClient(int id)
        {
            Client client = null;
            request = "SELECT nom, prenom, telephone from client where id=@id";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                client = new Client(id, reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return client;
        }
    }
}
