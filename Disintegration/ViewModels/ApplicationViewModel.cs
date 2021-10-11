using Disintegration.Commands;
using Disintegration.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace Disintegration.ViewModels
{
    class ApplicationViewModel : ViewModel
    {
        #region Commands
        public ICommand ApplicationExitCommand { get; }
        private void OnApplicationExitCommandExecuted(object p) => Environment.Exit(0);
        private bool CanApplicationExitCommandExecute(object p) => true;
        public ICommand ApplicationExpandCommand { get; }
        private void OnApplicationExpandCommandExecuted(object p) => App.Current.MainWindow.WindowState = App.Current.MainWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        private bool CanApplicationExpandCommandExecute(object p) => true;
        public ICommand ApplicationRollUpCommand { get; }
        private void OnApplicationRollUpCommandExecuted(object p) => App.Current.MainWindow.WindowState = WindowState.Minimized;
        private bool CanApplicationRollUpCommandExecute(object p) => true;
        #endregion
        public ApplicationViewModel()
        {
            ApplicationRollUpCommand = new LambdaCommand(OnApplicationRollUpCommandExecuted, CanApplicationRollUpCommandExecute);
            ApplicationExpandCommand = new LambdaCommand(OnApplicationExpandCommandExecuted, CanApplicationExpandCommandExecute);
            ApplicationExitCommand = new LambdaCommand(OnApplicationExitCommandExecuted, CanApplicationExitCommandExecute);
        }
    }
}