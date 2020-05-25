using System.ComponentModel;
using Bookstore.Mobile.ViewModels;
using Xamarin.Forms;

namespace Bookstore.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var vm= new MainPageViewModel();
            vm.Navigation = Navigation;

            BindingContext = vm;
        }
    }
}
