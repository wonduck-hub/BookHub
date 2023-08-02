using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookHub.Model
{
    public class BookRepository
    {
        private ObservableCollection<Book> books = new ObservableCollection<Book>();
        static string strConnect = "Server=127.0.0.1;Port=3306;Database=booklibrary;Uid=root;Pwd=4569;";
        static MySqlConnection connection = new MySqlConnection(strConnect);
        public BookRepository()
        {
            try
            {
                string sql = "SELECT * FROM book";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    books.Add(new Book((string)dr["name"], (string)dr["authorName"], (int)dr["pages"], (sbyte)dr["isBookBorrowed"]));
                }
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            connection.Close();
        }

        public ObservableCollection<Book> GetBooks()
        {
            ObservableCollection<Book> copy = new ObservableCollection<Book>();
            foreach (Book book in books)
            {
                copy.Add(book);
            }
            return copy;
        }
    }
}
