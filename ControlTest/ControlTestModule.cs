using ControlTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ControlTest
{
    public class ControlTestModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomUI>();
        }
    }
}