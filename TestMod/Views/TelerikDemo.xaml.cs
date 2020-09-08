using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;
using TestMod.Models;
using TestMod.ViewModels;

namespace TestMod.Views
{
    /// <summary>
    /// Interaction logic for TelerikDemo
    /// </summary>
    public partial class TelerikDemo : UserControl
    {
        private TelerikDemoViewModel model;
        public TelerikDemo()
        {
            InitializeComponent();
            model = this.DataContext as TelerikDemoViewModel;
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

        #region AutoText
        private void SongsAutoCompleteBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var autoCompleteBox = sender as RadAutoCompleteBox;
            if (autoCompleteBox.SelectedItem != null)
            {
            }
            else
            {
            }
        }

        #endregion

        private void BtAddSong_OnClick(object sender, RoutedEventArgs e)
        {
            if (songsAutoCompleteBox != null)
            {
                var text = songsAutoCompleteBox.SearchText;
                if (model.SongsList.Where(t=>t.Title == text).Any())
                {
                }
                else
                {
                    model.SongsList.Add(new Song(){Title = text});
                }
            }
        }
    }
}
