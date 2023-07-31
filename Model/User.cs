using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Model
{
    public class User
    {
        private int id;
        private int age;
        private int borrowedBooksCount;
        private string name;
        private string email;

        public User(int id, int age, string name, string email, int borrowedBooksCount)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.email = email;
            this.borrowedBooksCount = borrowedBooksCount;
        }

        public int Id { get { return id; } }
        public int Age { get { return age; } }
        public int BorrowedBooksCount { get { return borrowedBooksCount; } }
        public string Name { get { return name; } }
        public string Email { get { return email; } }
    }
}
