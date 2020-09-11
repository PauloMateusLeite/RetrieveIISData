using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IISEasyManager.Interfaces;
using Microsoft.Web.Administration;

namespace IISEasyManager.Model
{
    public  class MySite  
    { 
        public Site Site { get; set; }
        public string SiteName { get; set; }
        public string SitePool { get; set; }

    }
}
