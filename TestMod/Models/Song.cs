using System;

namespace TestMod.Models
{
    public class Song
    {
        private string title = String.Empty;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                }
            }
        }
    }
}
