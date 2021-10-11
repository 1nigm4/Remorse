using Disintegration.Commands;
using Disintegration.ViewModels.Base;
using Disintegration.Views.Pages;
using Disintegration.Views.Windows;
using System;
using System.Windows;
using System.Windows.Input;

namespace Disintegration.ViewModels
{
    class AuthWindowViewModel : ViewModel
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
        public ICommand TransitionRegisterCommand { get; }
        private void OnTransitionRegisterCommandExecuted(object p) => AuthWindow.Navigate(new RegPage());
        private bool CanTransitionRegisterCommandExecute(object p) => true;
        #endregion

        public AuthWindowViewModel()
        {
            TransitionRegisterCommand = new LambdaCommand(OnTransitionRegisterCommandExecuted, CanTransitionRegisterCommandExecute);
        }
    }
}
