using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using UpgradePrototype.IoC;
using UpgradePrototype.Views;
using ViewModels;

namespace UpgradePrototype
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ViewModelBindings>();
            var container = builder.Build();
            
            Current.MainWindow = new MainWindow();
            using (var scope = container.BeginLifetimeScope())
            {
                Current.MainWindow.DataContext = scope.Resolve<IMainWindowViewModel>();
            }
            Current.MainWindow.Show();
        }
    }
}