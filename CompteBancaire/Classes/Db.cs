using System;
using MySql.Data.MySqlClient;

namespace CompteBancaire.Classes
{
    public class Db
    {
        public Db()
        {
        }

        private static string connectionString = "Server=127.0.0.1;DataBase=DI2020;UserId=root;password=";
        public static MySqlConnection Connection { get => new MySqlConnection(connectionString); }
    }
}
