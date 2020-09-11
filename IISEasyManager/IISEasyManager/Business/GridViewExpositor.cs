using IISEasyManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISEasyManager.Business
{


    public class GridViewExpositor
    {
        private IGridKeeper _gridKeeper;

        public GridViewExpositor(IGridKeeper GridKeeper)
        {
            _gridKeeper = GridKeeper; 
        }

        public DataTable GetGridData()
        {
            return _gridKeeper.GetData();
        }
    }
}
