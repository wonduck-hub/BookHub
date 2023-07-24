using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookHub.Model
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        static string strConnect = "Server=localhost:3306;Database=booklibrary;Uid=root;Pwd=4569;";
        static MySqlConnection connection = new MySqlConnection(strConnect);
        public BookRepository()
        {
            string sql = "SELECT * FROM book";
            connection.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    books.Add(new Book((string)dr["name"], (string)dr["authorName"], (int)dr["pages"], (bool)dr["isBorrowed"]));
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            connection.Close();
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
