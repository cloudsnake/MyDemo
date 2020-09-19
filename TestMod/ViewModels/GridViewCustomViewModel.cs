using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestMod.Models;

namespace TestMod.ViewModels
{
    public class GridViewCustomViewModel : BindableBase
    {
        private ObservableCollection<CustomData> customDatas = new ObservableCollection<CustomData>();

        public ObservableCollection<CustomData> CustomDatas
        {
            get { return customDatas; }
            set
            {
                SetProperty(ref customDatas, value);
            }
        }

        public GridViewCustomViewModel()
        {
            var cd = new CustomData();
            cd.ProjectInfo = new TbEntity() {Info = "测试项目234234234234234"};
            cd.ContractInfos = new TbEntity() {Info = "降低房价俄军方咖啡机骄傲的时刻房价大幅retwrtwertwertwertwretwerwrwer"};
            cd.TbEntity6s = new TbEntity6()
            {
                DateTime1 = DateTime.Now,Amount1 = 1254,DateTime2 = DateTime.Now,DateTime3 = DateTime.Now,Amount2 = 123,Amount3 = 8889,
                Info1 = "TestMan01",
                Info2 = "TestMan02",
                Info3 = "TestMan03"

            };
           
            var cd2 = new CustomData();
            cd2.ProjectInfo = new TbEntity() { Info = "测试项目234234234234234" };
            cd2.ContractInfos = new TbEntity() { Info = "降低房价俄军方咖啡机骄傲的时刻房价大幅retwrtwertwertwertwretwerwrwer" };

            cd2.TbEntity6s = new TbEntity6()
            {
                DateTime1 = DateTime.Now, Amount1 = 2222, DateTime2 = DateTime.Now, DateTime3 = DateTime.Now, Amount2 = 2222, Amount3 = 2222,
                Info1="TestMan1",Info2 = "TestMan2",Info3 = "TestMan3"
            };

            List<CustomData> cds = new List<CustomData>();
            cds.Add(cd);
            cds.Add(cd2);

            CustomDatas = new ObservableCollection<CustomData>(cds);

        }
    }
}
