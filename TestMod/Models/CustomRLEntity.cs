using System.Collections.ObjectModel;
using Telerik.Windows.Controls.TimeBar;

namespace TestMod.Models
{
    public class CustomRLEntity
    {
        private string projectInfo = string.Empty;

        public string ProjectInfo
        {
            get
            {
                return this.projectInfo;
            }
            set
            {
                if (this.projectInfo != value)
                {
                    this.projectInfo = value;
                }
            }
        }
        private string contractInfo = string.Empty;

        public string ContractInfo
        {
            get
            {
                return this.contractInfo;
            }
            set
            {
                if (this.contractInfo != value)
                {
                    this.contractInfo = value;
                }
            }
        }

        private ObservableCollection<TbEntity> tbEntities = new ObservableCollection<TbEntity>();

        public ObservableCollection<TbEntity> TbEntities
        {
            get { return tbEntities; }
            set {
                if (this.tbEntities != value)
                {
                    this.tbEntities = value;
                }
            }
        }

        private ObservableCollection<string> tbCollections = new ObservableCollection<string>();

        public ObservableCollection<string> TbCollections
        {
            get { return tbCollections; }
            set {
                if (this.tbCollections != value)
                {
                    this.tbCollections = value;
                }
            }
        }

    }
}