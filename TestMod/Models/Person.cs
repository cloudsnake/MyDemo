using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace TestMod.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime Birthdary { get; set; }
        public ObservableCollection<FileNameDoc> FileNameDocs { get; set; }
    }

    public class FileNameDoc
    {
        //public FileNameDoc() { }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class PersonLightMessage
    {
        public PersonLightMessage()
        {
            FileNameDocs = new List<FileNameDoc>();
            Person = new Person();
        }
        public List<FileNameDoc> FileNameDocs { get; set; }
        public Person Person { get; set; }
    }
}
