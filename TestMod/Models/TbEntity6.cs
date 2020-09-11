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

        private long amount1 = 0;

        public long Amount1
        {
            get { return amount1; }
            set {
                if (amount1 != value)
                {
                    amount1 = value;
                }
            }
        }
        private long amount2 = 0;
        public long Amount2
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
        private long amount3 = 0;

        public long Amount3
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
    }
}