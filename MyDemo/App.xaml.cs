using Prism.Ioc;
using Prism.Modularity;
using MyDemo.Views;
using System.Windows;
using TestMod;

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
            moduleCatalog.AddModule<TestModModule>();

            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
