using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MethApp
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            _ = DataManager.SaveData();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DataManager.LoadData();
        }
    }
}
