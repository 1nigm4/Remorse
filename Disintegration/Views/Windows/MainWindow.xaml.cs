using Disintegration.Views.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Disintegration.Views.Windows
{
    public partial class MainWindow : Window
    {
        static Frame currentPage;
        Point mouseOffset;
        bool mousePressed;
        public MainWindow()
        {
            InitializeComponent();

            currentPage = Page;
            currentPage.Navigate(new AuthPage());
        }

        public static void Navigate(Page page) => currentPage.Navigate(page);

        private void Window_onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (!mousePressed)
                {
                    mousePressed = true;
                    mouseOffset = e.GetPosition(this);
                }
                else
                {
                    var mouseScreen = PointToScreen(Mouse.GetPosition(this));
                    this.Left = mouseScreen.X - mouseOffset.X;
                    this.Top = mouseScreen.Y - mouseOffset.Y;
                }
            }
            else mousePressed = false;
        }
    }
}