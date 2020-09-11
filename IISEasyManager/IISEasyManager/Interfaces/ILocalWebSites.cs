using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Site = Microsoft.Web.Administration.Site;

namespace IISEasyManager.Interfaces
{
    public interface ILocalWebSites
    {
        List<string> GetLocalWebsitesName();
        void StartWebSite(Site site);
        void StoptWebSite(Site site);
        void RestartWebSite(Site site);
    }
}
