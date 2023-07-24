using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookHub.Model
{
    public class UserRepository
    {
        private List<User> users = new List<User>();
        static string strConnect = "Server=127.0.0.1;Port=3306;Database=booklibrary;Uid=root;Pwd=4569;";
        static MySqlConnection connection = new MySqlConnection(strConnect);

        public UserRepository()
        {
            try
            {
                string sql = "SELECT * FROM user";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User((int)dr["id"], (int)dr["Age"], (string)dr["Name"], (string)dr["Email"]));
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            connection.Close();
        }

        public List<User> GetUsers()
        {
            return users;
        }

    }
}
