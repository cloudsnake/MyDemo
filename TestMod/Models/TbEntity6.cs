using System;

namespace TestMod.Models
{
    public class TbEntity6
    {
        #region Data1
        private DateTime dateTime1 = DateTime.Now;

        public DateTime DateTime1
        {
            get { return dateTime1; }
            set {
                if (dateTime1 != value && value != null )
                {
                    dateTime1 = value;
                }
            }
        }
        private DateTime dateTime2 = DateTime.Now;
        public DateTime DateTime2
        {
            get { return dateTime2; }
            set
            {
                if (dateTime2 != value && value != null)
                {
                    dateTime2 = value;
                }
            }
        }
        private DateTime dateTime3 = DateTime.Now;
        public DateTime DateTime3
        {
            get { return dateTime3; }
            set
            {
                if (dateTime3 != value && value != null)
                {
                    dateTime3 = value;
                }
            }
        }
        #endregion

        #region Amount1

        private double amount1 = 0;

        public double Amount1
        {
            get { return amount1; }
            set {
                if (amount1 != value)
                {
                    amount1 = value;
                }
            }
        }
        private double amount2 = 0;
        public double Amount2
        {
            get { return amount2; }
            set
            {
                if (amount2 != value)
                {
                    amount2 = value;
                }
            }
        }
        private double amount3 = 0;

        public double Amount3
        {
            get { return amount3; }
            set
            {
                if (amount3 != value)
                {
                    amount3 = value;
                }
            }
        }

        #endregion

        private string info1 = string.Empty;

        public string Info1
        {
            get { return info1; }
            set {
                if (info1 != value)
                {
                    info1 = value;
                }
            }
        }
        private string info2 = string.Empty;
        public string Info2
        {
            get { return info2; }
            set
            {
                if (info2 != value)
                {
                    info2 = value;
                }
            }
        }

        private string info3 = string.Empty;
        public string Info3
        {
            get { return info3; }
            set
            {
                if (info3 != value)
                {
                    info3 = value;
                }
            }
        }

    }
}