using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Model
{
    public class Book
    {
        private int pages;

        private string name;
        private string authorName;
        private sbyte isBookBorrowed;

        public Book(string name, string authorName, int pages, sbyte isBookBorrowed)
        {
            this.name = name;
            this.authorName = authorName;
            this.pages = pages;
            this.isBookBorrowed = isBookBorrowed;
        }

        public int Pages { get { return pages; } }
        public string Name { get { return name; } }
        public string AuthorName { get { return authorName; } }
        public sbyte IsBookBorrowed { get { return isBookBorrowed; } set { isBookBorrowed = value; } }

    }
}
