﻿using GalaSoft.MvvmLight.Messaging;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TestMod.Models;

namespace TestMod.ViewModels
{
    public class TelerikDemoViewModel : BindableBase
    {
        private ObservableCollection<Person> persons;
        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set { SetProperty(ref persons, value); }
        }


        public TelerikDemoViewModel()
        {
            Messenger.Default.Register<PersonLightMessage>(this, "AddFile", OnAddFileMessage);
            Messenger.Default.Register<PersonLightMessage>(this, "ClearFile", OnClearFileMessage);
            CreatePersons();
        }
        private void OnClearFileMessage(PersonLightMessage message)
        {
            foreach (var item in Persons)
            {
                if (item.Name == message.Person.Name)
                {
                    item.FileNameDocs.Clear();
                }
            }
        }

        private void OnAddFileMessage(PersonLightMessage message)
        {
            foreach (var item in Persons)
            {
                if (item.Name == message.Person.Name)
                {
                    item.FileNameDocs.AddRange(message.FileNameDocs);
                }
            }
        }

        private void CreatePersons()
        {
            var list = new List<Person>()
            {
                new Person{Name = "Test11",Age=14,Birthdary = DateTime.Now,IsAdmin = false,FileNameDocs = new ObservableCollection<FileNameDoc>(){new FileNameDoc(){Name="1234",Path="kifjkdf"} } },
                new Person{Name = "Test12",Age=23,Birthdary = DateTime.Now,IsAdmin = true,FileNameDocs = new ObservableCollection<FileNameDoc>()}
            };

            Persons = new ObservableCollection<Person>(list);
        }
    }
}
