using FtpClient.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace FtpClient
{
    public class FtpClientModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ClientUi>();
        }
    }
}