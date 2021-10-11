using Disintegration.Models;
using Disintegration.ViewModels;
using System.Windows;

namespace Disintegration.Views.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow(User user)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel() { User = user };
        }
    }
}
