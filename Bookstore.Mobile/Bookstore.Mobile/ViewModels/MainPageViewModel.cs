using System.Collections.ObjectModel;
using Bookstore.Api.Client.Models;
using Bookstore.Api.Client.Services;

namespace Bookstore.Mobile.ViewModels
{
    public class MainPageViewModel
    {
        // TODO: move all books related functionality to BooksPage/BooksPageViewModel
        public ObservableCollection<Book> Books { get; set; }

        private readonly BookService _bookService;
        public MainPageViewModel()
        {
            _bookService = new BookService();
            Books = new ObservableCollection<Book>();
        }

        public void Initialize()
        {
            var books = _bookService.Get();

            Books.Clear();

            foreach (var book in Books)
            {
                Books.Add(book);
            }
        }




    }
}
