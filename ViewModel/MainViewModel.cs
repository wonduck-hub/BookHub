using BookHub.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Book> bookItem = new ObservableCollection<Book>();
        private ObservableCollection<Book> searchBookItem = new ObservableCollection<Book>();
        private int bookTotal = 0;
        private int totalBorrowedBookCount = 0;
        private string searchNameText = "modern";
        
        public MainViewModel()
        {
            bookItem = bookR.GetBooks();
            searchBookItem = bookR.GetBooks();
            bookTotal = bookItem.Count;
            foreach (Book book in bookItem)
            {
                //TODO IsBookBorrowed를 bool형으로 수정
                if (book.IsBookBorrowed)
                {
                    totalBorrowedBookCount++;
                }
            }
            this.SearchNameCommand = new DelegateCommand(ExecuteSearchName);
        }

        public IDelegateCommand SearchNameCommand { get; protected set; }
        void ExecuteSearchName(object param)
        {
            //TODO 나중에 해쉬검색으로 수정
            if (SearchTextName == string.Empty || SearchTextName == "")
            {
                SearchBookItem = BookItem;
            }
            else
            {
                if(SearchBookItem.Count > 0)
                    SearchBookItem.Clear();

                for (int i = 0; i < BookItem.Count; ++i)
                {
                    if (BookItem[i].Name.Contains(SearchTextName, StringComparison.OrdinalIgnoreCase))
                    {
                        SearchBookItem.Add(BookItem[i]);
                    }
                }
            }
        }
        public ObservableCollection<Book> BookItem
        {
            get { return bookItem; }
            set
            {
                if(SetProperty<ObservableCollection<Book>>(ref bookItem, value)) { }
            }
        }
        public ObservableCollection<Book> SearchBookItem
        {
            get { return searchBookItem; }
            set
            {
                if(SetProperty<ObservableCollection<Book>>(ref searchBookItem, value)) { }
            }
        }
        public string SearchTextName
        {
            get { return searchNameText; }
            set
            {
                if(SetProperty<string>(ref searchNameText, value)) { }
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
