using BookHub.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookHub.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private BookRepository bookR = new BookRepository();
        private List<Book> bookItem;
        private int bookTotal = 0;
        private int totalBorrowedBookCount = 0;
        private string bookName = string.Empty;
        
        public MainViewModel()
        {
            bookItem = bookR.GetBooks();
            bookTotal = bookItem.Count;
            foreach (Book book in bookItem)
            {
                //TODO IsBookBorrowed를 bool형으로 수정
                if (book.IsBookBorrowed)
                {
                    totalBorrowedBookCount++;
                }
            }
        }

        public List<Book> BookItem
        {
            get { return bookItem; }
            set 
            {
                //TODO 선택시 내용 변경되는 코드
            }
        }
        public int BookTotal
        {
            get { return bookTotal; }
        }
        public int TotalBorrowedBookCount
        {
            get { return totalBorrowedBookCount; }
        }
    }
}
