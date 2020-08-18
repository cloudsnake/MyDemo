using System;
using System.Windows.Controls;
using Telerik.Windows.Controls.GridView;
using TestMod.Models;

namespace TestMod.Views
{
    /// <summary>
    /// Interaction logic for TelerikDemo
    /// </summary>
    public partial class TelerikDemo : UserControl
    {
        public TelerikDemo()
        {
            InitializeComponent();
        }

        private void gridAd0_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
        {
            var employee = new Person();
            employee.Name = "默认";
            employee.Age = 20;
            employee.Birthdary = DateTime.Now;
            employee.IsAdmin = false;
            e.NewObject = employee;
        }

        private void gridAd0_RowEditEnded(object sender, Telerik.Windows.Controls.GridViewRowEditEndedEventArgs e)
        {
            if (e.EditAction == GridViewEditAction.Cancel)
            {
                return;
            }
            if (e.EditOperationType == GridViewEditOperationType.Insert)
            {
                //Add the new entry to the data base. 
            }
        }

        private void gridAd0_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
