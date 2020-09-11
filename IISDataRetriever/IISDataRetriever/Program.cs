using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace IISDataRetriever
{
    class Program
    {
        static void Main(string[] args)
        {

            //int iisNumber = 2;

            using (ServerManager serverManager = new ServerManager())
            {
                foreach (var currSite in serverManager.Sites)
                {
                    var applicationRoot =
                         currSite.Applications.Where(a => a.Path == "/").Single();
                    var virtualRoot =
                             applicationRoot.VirtualDirectories.Where(v => v.Path == "/").Single();
                    var removeLastBar = virtualRoot.PhysicalPath.EndsWith(@"\") ? virtualRoot.PhysicalPath.Remove(virtualRoot.PhysicalPath.Length - 1, 1) : virtualRoot.PhysicalPath;
                    var finalPath = removeLastBar.Split('\\').Last();
                    Console.WriteLine(finalPath) ;
                }
                Console.WriteLine("");
                Console.WriteLine("Pools");
                Console.WriteLine("");
                foreach (var appPool in new ServerManager().ApplicationPools)
                {
                    Console.WriteLine(appPool.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
