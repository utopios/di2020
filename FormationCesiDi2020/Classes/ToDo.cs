using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FormationCesiDi2020.Classes
{
    public class ToDo
    {
        private string todo;
        public ToDo()
        {
        }

        public string Todo { get => todo; set => todo = value; }

        public void Save()
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;DataBase=DI2020;UserId=root;password=");
        }
    }
}
