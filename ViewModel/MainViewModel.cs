using BookHub.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private BookRepository bookR = new BookRepository();
        private IEnumerable<Book> bookItem;
        public MainViewModel()
        {
            bookItem = bookR.GetBooks();
        }

        public IEnumerable<Book> BookItem
        {
            get { return bookItem; }
            set 
            {
            
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
