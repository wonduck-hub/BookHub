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
        private Boolean isBookBorrowed;

        public Book(string name, string authorName, int pages, sbyte isBookBorrowed)
        {
            this.name = name;
            this.authorName = authorName;
            this.pages = pages;
            if (isBookBorrowed == 1)
                this.isBookBorrowed = true;
            else
                this.isBookBorrowed = false;
        }

        public int Pages { get { return pages; } }
        public string Name { get { return name; } }
        public string AuthorName { get { return authorName; } }
        public Boolean IsBookBorrowed { get { return isBookBorrowed; } set { isBookBorrowed = value; } }

    }
}
