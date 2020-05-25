using System.Collections.ObjectModel;
using System.Windows.Input;
using Bookstore.Api.Client.Models;
using Bookstore.Api.Client.Services;
using Bookstore.Mobile.Views;
using Xamarin.Forms;

namespace Bookstore.Mobile.ViewModels
{
    public class MainPageViewModel:BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand NavigateToBooksCommand => new Command(async () =>
        {
            await Navigation.PushAsync(new BooksPage());
        });
    }
}
