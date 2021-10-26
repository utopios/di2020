using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FormationCesiDi2020.Classes
{
    public class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static string request;
        private static MySqlCommand command;
        private static MySqlConnection connection;
        private static MySqlDataReader reader;
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Contact()
        {
        }

        public bool Save()
        {
            request = "INSERT INTO contact (nom, prenom, telephone) values (@nom, @prenom, @telephone); SELECT LAST_INSERT_ID()";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@nom", Nom));
            command.Parameters.Add(new MySqlParameter("@prenom", Prenom));
            command.Parameters.Add(new MySqlParameter("@telephone", Telephone));
            connection.Open();
            Id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public bool Delete()
        {
            request = "DELETE FROM contact where id=@id";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", Id));       
            connection.Open();
            int nb = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nb == 1;
        }

        public static Contact GetContact(string telephone)
        {
            Contact contact = null;
            request = "SELECT id, nom, prenom FROM contact where telephone = @telephone";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("telephone", telephone));
            connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                contact = new Contact()
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2),
                    Telephone = telephone
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contact;
        }

        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id, nom, prenom, telephone FROM contact";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact()
                {
                    Id = reader.GetInt32(0),
                    Nom = reader.GetString(1),
                    Prenom = reader.GetString(2),
                    Telephone = reader.GetString(3)
                };
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }
    }
}
