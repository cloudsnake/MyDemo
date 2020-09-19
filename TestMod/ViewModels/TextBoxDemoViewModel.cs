using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMod.ViewModels
{
    public class TextBoxDemoViewModel : BindableBase
    {
        private double fenshu = 0.0;

        public double FenShu
        {
            get { return fenshu; }
            set
            {
                SetProperty(ref fenshu, value);
                if (value != null)
                {
                    Fenshu10 = 10 * value;
                }
            }
        }

        private double fenshu10 = 0.0;

        public double Fenshu10
        {
            get { return fenshu10; }
            set { SetProperty(ref fenshu10, value); }
        }
        public TextBoxDemoViewModel()
        {

        }
    }
}
