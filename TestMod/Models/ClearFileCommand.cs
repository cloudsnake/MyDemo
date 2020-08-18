using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace TestMod.Models
{
    public class ClearFileCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PersonLightMessage message = new PersonLightMessage();
            message.Person = parameter as Person;
            message.FileNameDocs = new List<FileNameDoc>();

            Messenger.Default.Send<PersonLightMessage>(message, "ClearFile");

        }
    }
}
