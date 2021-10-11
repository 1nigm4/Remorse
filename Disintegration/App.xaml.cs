using Disintegration.Data;
using System.Windows;

namespace Disintegration
{
    public partial class App : Application
    {
        public static Database Db;

        public App()
        {
            Db = new Database();
        }

        public static void Navigate(Window window)
        {
            window.Show();
            Current.MainWindow.Close();
            window.MaxHeight = SystemParameters.WorkArea.Height;
            Current.MainWindow = window;
        }
    }
}
