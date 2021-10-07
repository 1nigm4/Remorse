using Disintegration.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
