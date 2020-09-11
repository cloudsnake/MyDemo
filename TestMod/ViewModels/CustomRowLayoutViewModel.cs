using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestMod.Models;

namespace TestMod.ViewModels
{
    public class CustomRowLayoutViewModel : BindableBase
    {
        private ObservableCollection<CustomRLEntity> customRLEntities;

        public ObservableCollection<CustomRLEntity> CustomRlEntities
        {
            get { return customRLEntities; }
            set { SetProperty(ref customRLEntities, value); }
        }

        public CustomRowLayoutViewModel()
        {
            CustomRlEntities = new ObservableCollection<CustomRLEntity>();
             var crl = new CustomRLEntity(){ProjectInfo = "项目信息990",ContractInfo = "合同收款条目123"};
            List<TbEntity> tbs = new List<TbEntity>();
            tbs.Add(new TbEntity() { TbTime = DateTime.Now, Amount = 1234 });
            tbs.Add(new TbEntity() { TbTime = DateTime.Now, Amount = 6666 });
            crl.TbEntities.AddRange(tbs);
            string ss = $"{DateTime.Now}   {0:F2}元    jdifje";
            string sst = string.Format(ss, 1234.23);
            crl.TbCollections.Add(sst);

            CustomRlEntities.Add(crl);
        }
    }
}
