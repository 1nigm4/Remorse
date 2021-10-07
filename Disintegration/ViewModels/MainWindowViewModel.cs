using Disintegration.Commands;
using Disintegration.ViewModels.Base;
using Disintegration.Views.Pages;
using Disintegration.Views.Windows;
using System;
using System.Windows;
using System.Windows.Input;

namespace Disintegration.ViewModels
{
    class MainWindowViewModel : ViewModel
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
        public ICommand ApplicationExitCommand { get; }
        private void OnApplicationExitCommandExecuted(object p) => Environment.Exit(0);
        private bool CanApplicationExitCommandExecute(object p) => true;

        public ICommand ApplicationRollUpCommand { get; }
        private void OnApplicationRollUpCommandExecuted(object p) => App.Current.MainWindow.WindowState = WindowState.Minimized;
        private bool CanApplicationRollUpCommandExecute(object p) => true;

        public ICommand TransitionRegisterCommand { get; }
        private void OnTransitionRegisterCommandExecuted(object p) => MainWindow.Navigate(new RegPage());
        private bool CanTransitionRegisterCommandExecute(object p) => true;
        #endregion

        public MainWindowViewModel()
        {
            ApplicationExitCommand = new LambdaCommand(OnApplicationExitCommandExecuted, CanApplicationExitCommandExecute);
            ApplicationRollUpCommand = new LambdaCommand(OnApplicationRollUpCommandExecuted, CanApplicationRollUpCommandExecute);
            TransitionRegisterCommand = new LambdaCommand(OnTransitionRegisterCommandExecuted, CanTransitionRegisterCommandExecute);
        }
    }
}
