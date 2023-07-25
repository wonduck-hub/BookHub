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
    internal class MainViewModel : BindableBase
    {
        private BookRepository bookR = new BookRepository();
        private List<Book> bookItem;
        private UserRepository userR = new UserRepository();
        private List<User> userItem;
        
        public MainViewModel()
        {
            bookItem = bookR.GetBooks();
            userItem = userR.GetUsers();
        }

        public List<Book> BookItem
        {
            get { return bookItem; }
            set 
            {
                //TODO 선택시 내용 변경되는 코드
            }
        }
        public List <User> UserItem
        {
            get { return userItem; }
            set
            {

            }
        }

    }
}
