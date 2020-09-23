using System.Windows.Controls;
using GridLayout.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace GridLayout
{
    public class GridLayoutModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GridLayoutMod>();
        }
    }
}