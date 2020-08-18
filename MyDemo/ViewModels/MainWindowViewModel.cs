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

        public MainWindowViewModel(IRegionManager regionManager)
        {
            //view discovery
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Demo));
        }
    }
}
