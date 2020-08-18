using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestMod.Models;

namespace TestMod.ViewModels
{
    public class DemoViewModel : BindableBase
    {
        private ObservableCollection<Person> peoples;
        public ObservableCollection<Person> Peoples
        {
            get { return peoples; }
            set { SetProperty(ref peoples, value); }
        }

        public DemoViewModel()
        {

        }
    }
}
