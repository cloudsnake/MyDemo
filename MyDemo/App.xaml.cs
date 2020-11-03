using Prism.Ioc;
using Prism.Modularity;
using MyDemo.Views;
using System.Windows;
using AutoMapperMod;
using GridLayout;
using ControlTest;
using FtpClient;

namespace MyDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<AutoMapperModModule>();
            moduleCatalog.AddModule<GridLayoutModule>();
            moduleCatalog.AddModule<ControlTestModule>();
            moduleCatalog.AddModule<FtpClientModule>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
