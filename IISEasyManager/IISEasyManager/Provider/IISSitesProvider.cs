using IISEasyManager.Interfaces;
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace IISEasyManager.Provider
{
    public class IISSitesProvider : ILocalWebSites
    {
        public List<string> GetLocalWebsitesName()
        {
            List<string> ret = new List<string>(); 
            using (ServerManager serverManager = new ServerManager())
            {
                foreach (var currSite in serverManager.Sites)
                {
                    var applicationRoot =  currSite.Applications.Where(a => a.Path == "/").Single();
                    var virtualRoot = applicationRoot.VirtualDirectories.Where(v => v.Path == "/").Single();
                    var removeLastBar = virtualRoot.PhysicalPath.EndsWith(@"\") ? virtualRoot.PhysicalPath.Remove(virtualRoot.PhysicalPath.Length - 1, 1) : virtualRoot.PhysicalPath;
                    var finalPath = removeLastBar.Split('\\').Last();
                    ret.Add(removeLastBar);
                }
            }
            return ret;
        }

        public void RestartWebSite(Site site)
        {
            throw new NotImplementedException();
        }

        public void StartWebSite(Site site)
        {
            throw new NotImplementedException();
        }

        public void StoptWebSite(Site site)
        {
            throw new NotImplementedException();
        }
    }
}
