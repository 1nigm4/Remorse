using Disintegration.ViewModels;
using System.Windows.Controls;

namespace Disintegration.Views.Pages
{
    public partial class AuthPage : Page
    {
        AuthPageViewModel ViewModel;
        public AuthPage()
        {
            InitializeComponent();

            ViewModel = new AuthPageViewModel();
            DataContext = ViewModel;
        }

        private void OnPasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewModel.Password = (sender as PasswordBox).Password;
        }
    }
}
