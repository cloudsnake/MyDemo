using AutoMapperMod.Models.Mapper;
using AutoMapperMod.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AutoMapperMod
{
    public class AutoMapperModModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //注册映射配置
            AutoMapperStartupTask auto = new AutoMapperStartupTask();
            auto.Execute();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }

    }
}