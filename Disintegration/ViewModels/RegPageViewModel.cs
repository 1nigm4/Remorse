using Disintegration.Commands;
using Disintegration.Models;
using Disintegration.ViewModels.Base;
using Disintegration.Views.Pages;
using Disintegration.Views.Windows;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Disintegration.ViewModels
{
    class RegPageViewModel : ViewModel
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
        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        #endregion

        #region Commands
        public ICommand RegisterCommand { get; }
        private async void OnRegisterCommandExecuted(object p)
        {
            if (App.Db.users.Any(u => u.Login == Login))
            {
                MessageBox.Show("Пользователь уже существует!");
                return;
            }

            User newUser = new User() { Login = this.Login, Password = this.Password, Name = this.Name };
            await App.Db.AddAsync(newUser);
            await App.Db.SaveChangesAsync();
            MainWindow.Navigate(new AuthPage());
        }
        private bool CanRegisterCommandExecute(object p) => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Name);

        public ICommand TransitionAuthCommand { get; }
        private void OnTransitionAuthCommandExecuted(object p) => MainWindow.Navigate(new AuthPage());
        private bool CanTransitionAuthCommandExecute(object p) => true;
        #endregion

        public RegPageViewModel()
        {
            RegisterCommand = new LambdaCommand(OnRegisterCommandExecuted, CanRegisterCommandExecute);
            TransitionAuthCommand = new LambdaCommand(OnTransitionAuthCommandExecuted, CanTransitionAuthCommandExecute);
        }


    }
}
