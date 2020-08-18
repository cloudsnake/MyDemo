using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Telerik.Windows.Controls;

namespace TestMod.Models
{
    public class AddFileCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.IsDragDropEnabled = true;
            
            openFileDialog.ShowDialog();

            if (openFileDialog.DialogResult == true)
            {
                var result = openFileDialog.FileNames;
                PersonLightMessage message = new PersonLightMessage();
                message.Person = parameter as Person;
                foreach (var item in result)
                {
                    FileInfo fileInfo = new FileInfo(item);
                    message.FileNameDocs.Add(new FileNameDoc() { Name = fileInfo.Name, Path = fileInfo.DirectoryName });
                }
                Messenger.Default.Send<PersonLightMessage>(message, "AddFile");
            }

        }
    }
}
