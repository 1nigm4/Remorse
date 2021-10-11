using Disintegration.Commands;
using Disintegration.ViewModels.Base;
using Disintegration.Views.Pages;
using Disintegration.Views.Windows;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Disintegration.ViewModels
{
    class AuthPageViewModel : ViewModel
    {
        #region Properties
        private string login;
        public string Login
        {
            get => login;
            set => Set(ref login, value);
        }
        private string password;
        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }
        #endregion
        #region Commands
        public ICommand AuthCommand { get; }
        private void OnAuthCommandExecuted(object p)
        {
            bool isLogged = App.Db.users.Any(u => u.Login == this.Login && u.Password == this.Password);
            if (isLogged)
                App.Navigate(new MainWindow(App.Db.users.Where(u => u.Login == Login).FirstOrDefault()));
            else
                MessageBox.Show("Неверный логин или пароль!");
        }
        private bool CanAuthCommandExecute(object p) => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);
        public ICommand TransitionRegisterCommand { get; }
        private void OnTransitionRegisterCommandExecuted(object p) => AuthWindow.Navigate(new RegPage());
        private bool CanTransitionRegisterCommandExecute(object p) => true;
        #endregion
        public AuthPageViewModel()
        {


            AuthCommand = new LambdaCommand(OnAuthCommandExecuted, CanAuthCommandExecute);
            TransitionRegisterCommand = new LambdaCommand(OnTransitionRegisterCommandExecuted, CanTransitionRegisterCommandExecute);
        }
    }
}
