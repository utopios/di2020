using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CompteBancaire.Classes
{
    public class Operation
    {
        private decimal montant;
        private int numero;
        //private static int compteur = 0;

        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;
        public Operation(decimal m)
        {
            Montant = m;
            //numero = ++compteur;
        }

        public decimal Montant { get => montant; set => montant = value; }

        public bool Save(int compteId)
        {

            request = "INSERT INTO client (montant, compteId) values(@montant, @compteId);select last_insert_id()";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@montant", Montant));
            command.Parameters.Add(new MySqlParameter("@compteId", compteId));
            connection.Open();
            numero = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return numero > 0;
        }


        public List<Operation> GetOperations(int compteId)
        {
            List<Operation> operations = new List<Operation>();
            request = "SELECT montant from operation where compteId=@compteId";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@compteId", compteId));
            connection.Open();
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                operations.Add(new Operation(reader.GetDecimal(0)));
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return operations;
        }
    }
}
