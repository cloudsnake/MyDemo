using TestMod.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace TestMod
{
    public class TestModModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Demo>();
            containerRegistry.RegisterForNavigation<TelerikDemo>();
        }
    }
}