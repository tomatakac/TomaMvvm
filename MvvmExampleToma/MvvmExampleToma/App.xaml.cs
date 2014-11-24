using Dal;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using MvvmExampleToma.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmExampleToma
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container = new UnityContainer();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container.RegisterType<IRepository, Repository>(new PerResolveLifetimeManager());
            _container.RegisterType<InvoiceMgrEntities>(new PerResolveLifetimeManager());
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => _container.Resolve(type));
        }
    }
}
