using System;
using System.Collections.Generic;
using System.Windows.Controls;
using TestMod.Models;
using TestMod.ViewModels;

namespace TestMod.Views
{
    /// <summary>
    /// Interaction logic for Demo
    /// </summary>
    public partial class Demo : UserControl
    {
        private DemoViewModel model;
        public Demo()
        {
            Xceed.Wpf.DataGrid.Licenser.LicenseKey = "DGP70-D0PYR-0HLRH-10KA";
            InitializeComponent();
            model = this.DataContext as DemoViewModel;
        }

        private void DataGridCollectionViewSource_CreatingNewItem(object sender, Xceed.Wpf.DataGrid.DataGridCreatingNewItemEventArgs e)
        {
            e.NewItem = new Person()
            {
                Name = Guid.NewGuid().ToString().Substring(6),
                Age = 123,
                IsAdmin = true,
                Birthdary = DateTime.Now
            };
            e.Handled = true;
        }

        private void DataGridCollectionViewSource_NewItemCommitted(object sender, Xceed.Wpf.DataGrid.DataGridItemEventArgs e)
        {
            List<Person> source = e.CollectionView.SourceCollection as List<Person>;
            source.Add((Person)e.Item);
            //Person.AutoIncrementID = Person.AutoIncrementID + 1;
            // the new item is always added at the end of the list.     
            //e.Index = source.Count - 1;
            //e.NewCount = source.Count;
            //e.Handled = true;
            
        }

        private void DataGridCollectionViewSource_CancelingNewItem(object sender, Xceed.Wpf.DataGrid.DataGridItemHandledEventArgs e)
        {

            e.Handled = true;
        }
    }
}
