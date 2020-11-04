using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlTest.ViewModels
{
    public class CustomUIViewModel : BindableBase
    {
        public DelegateCommand ConvertTimeCommand { get; set; }
        public CustomUIViewModel()
        {
            ConvertTimeCommand = new DelegateCommand(OnConvertTime);
        }
        private void OnConvertTime()
        {
            DateTime dt1 = DateTime.MinValue;
            DateTime dt2 = DateTime.MinValue;
            DateTime dt3 = DateTime.MinValue;
            DateTime dt4 = DateTime.MinValue;
            DateTime dt5 = DateTime.MinValue;
            string timeStr1 = "2020/12/21";
            string timeStr2 = "2020-11-22";
            string timeStr3 = "2020年2月23日";
            string timeStr4 = "2020.2.23";
            string timeStr5 = "2020。2。23";

            dt1 = Convert.ToDateTime(timeStr1);
            dt2 = Convert.ToDateTime(timeStr2);
            dt3 = Convert.ToDateTime(timeStr3);
            dt4 = Convert.ToDateTime(timeStr4);
            try
            {
                dt5 = Convert.ToDateTime(timeStr5);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
