using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using TestMod.Views;

namespace MyDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand<string> ShowModCommand { get; set; }
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            ShowModCommand = new DelegateCommand<string>(OnShowMod);
            //view discovery
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(Demo));
        }

        private void OnShowMod(string navigatePath)
        {
                //删除原有view
            if (navigatePath != null)
            {
                //if (_regionManager.Regions.ContainsRegionWithName("ProjectPartRegion"))
                //{
                //    try
                //    {
                //        _regionManager.Regions.Remove("ProjectPartRegion");
                //    }
                //    catch (Exception e)
                //    {
                //    }
                //}
                var splitDots = navigatePath.Split('.');
                if (splitDots != null && splitDots.Length > 0)
                {
                    _regionManager.RequestNavigate("ContentRegion", splitDots[splitDots.Length-1]);

                }
                else 
                    _regionManager.RequestNavigate("ContentRegion", navigatePath);

            }

        }

    }
}
