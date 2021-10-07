using Disintegration.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Disintegration.Views.Pages
{
    public partial class RegPage : Page
    {
        RegPageViewModel ViewModel;
        public RegPage()
        {
            InitializeComponent();

            ViewModel = new RegPageViewModel();
            DataContext = ViewModel;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = (sender as PasswordBox).Password;
        }
    }
}
