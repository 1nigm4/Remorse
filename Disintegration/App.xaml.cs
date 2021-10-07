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
    }
}
