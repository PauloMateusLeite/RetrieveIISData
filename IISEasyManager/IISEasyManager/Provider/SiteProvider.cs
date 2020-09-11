using IISEasyManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace IISEasyManager.Provider
{

    public class SiteProvider : ILocalSite
    {
        private Site _site { get; set; }

        public SiteProvider(Site site)
        {
            _site = site;
        }

        public string GetSiteName()
        {
            var applicationRoot = _site.Applications.Where(a => a.Path == "/").Single();
            var virtualRoot = applicationRoot.VirtualDirectories.Where(v => v.Path == "/").Single();
            var removeLastBar = virtualRoot.PhysicalPath.EndsWith(@"\") ? virtualRoot.PhysicalPath.Remove(virtualRoot.PhysicalPath.Length - 1, 1) : virtualRoot.PhysicalPath;
            var finalPath = removeLastBar.Split('\\').Last();
            return removeLastBar;
        }

        public string GetSitePool()
        {
            throw new NotImplementedException();
        }
    }
}
