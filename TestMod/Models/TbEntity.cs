using System;

namespace TestMod.Models
{
    public class TbEntity
    {
        private DateTime tbTime = DateTime.Now;

        public DateTime TbTime
        {
            get
            {
                return this.tbTime;
            }
            set
            {
                if (this.tbTime != value)
                {
                    this.tbTime = value;
                }
            }
        }
        private decimal amount = 0;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }

        private string info = string.Empty;

        public string Info
        {
            get { return info; }
            set {
                if (info != value)
                {
                    info = value;
                }
            }
        }

    }
}