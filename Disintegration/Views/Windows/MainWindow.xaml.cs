using System.Windows;
using System.Windows.Controls;

namespace Disintegration.Views.Windows
{
    public partial class MainWindow : Window
    {
        static Frame currentPage;
        public MainWindow()
        {
            InitializeComponent();

            currentPage = Page;
        }
    }
}
