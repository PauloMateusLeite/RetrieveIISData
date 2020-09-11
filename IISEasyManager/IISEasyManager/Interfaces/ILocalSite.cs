using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISEasyManager.Interfaces
{
   public interface ILocalSite
    {
        string GetSiteName();

        string GetSitePool();
    }
}
