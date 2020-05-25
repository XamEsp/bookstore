using System.Collections.ObjectModel;
using Acr.UserDialogs;
using Bookstore.Api.Client.Models;
using Bookstore.Api.Client.Services;
using Xamarin.Forms;

namespace Bookstore.Mobile.ViewModels
{
    public class BooksPageViewModel:BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        private readonly BookService _bookService;
        
        public BooksPageViewModel()
        {
            _bookService = new BookService();
            Books = new ObservableCollection<Book>();
        }

        public async void Initialize()
        {
            using (UserDialogs.Instance.Loading())
            {
                var books = await _bookService.Get();

                Books.Clear();

                foreach (var book in books)
                {
                    Books.Add(book);
                }
            }
            
        }
    }
}
