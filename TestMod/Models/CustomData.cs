using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace TestMod.Models
{
    public class CustomData
    {
        private TbEntity projectInfo = new TbEntity();
        /// <summary>
        /// 项目信息
        /// </summary>
        public TbEntity ProjectInfo
        {
            get { return projectInfo; }
            set
            {
                if (projectInfo != value)
                {
                    projectInfo = value;
                }
            }
        }

        private TbEntity contractInfos = new TbEntity();
        /// <summary>
        /// 合同信息
        /// </summary>
        public TbEntity ContractInfos
        {
            get { return contractInfos; }
            set {
                if (contractInfos != value)
                {
                    contractInfos = value;
                }
            }
        }

        private TbEntity6 tbEntity6s = new TbEntity6();

        public TbEntity6 TbEntity6s
        {
            get { return tbEntity6s; }
            set {
                if (tbEntity6s != value)
                {
                    tbEntity6s = value;
                }
            }
        }
    }

    public class Project
    {

    }
    
}