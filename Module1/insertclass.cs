using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Module1
{
    public class insertclass
    {
        public bool TestInsert(string name, int age, int salary, int phone)
        {
            if (phone.ToString().Length >= 9 && age > 18)
            {
                return true;
            }
            return false;
        }

        public bool TestDelete(int id)
        {
            if (id > 0)
            {
                string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                string query = "SELECT * FROM emptable WHERE id='" + id + "';";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();

                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return true;
                        }
                        connection.Close();
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public bool DatabaseConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=mod4;UID=root;PASSWORD=admin;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                return true;
            }
        }
    }
}
