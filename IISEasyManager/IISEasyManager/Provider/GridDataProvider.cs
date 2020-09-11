using IISEasyManager.Common;
using IISEasyManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISEasyManager.Provider
{
    public class GridDataProvider : IGridKeeper
    {
        private ILocalWebSites _localWebSites;

        public GridDataProvider(ILocalWebSites localWebSites)
        {
            _localWebSites = localWebSites;
        }
         
        public DataTable GetData()
        {
            List<string[]> list = new List<string[]>();
            var siteNamesList = _localWebSites.GetLocalWebsites();
            foreach (string name in siteNamesList)
            {
                list.Add(new string[] { name , "" });
            }

            return DataTableTools.ConvertListToDataTable(list);
        }

      
    }
}
