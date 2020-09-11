using IISEasyManager.Interfaces;
using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISEasyManager.Provider
{
    public class PoolProvider : ILocalAppPool
    {
        public List<string> GetLocalAppPools()
        {
            List<string> ret = new List<string>();
            using (ServerManager serverManager = new ServerManager())
            {
                foreach (var appPool in new ServerManager().ApplicationPools)
                {
                    ret.Add(appPool.Name);
                }

                return ret;
            }
        }

        public void RestartApplicationPool(ApplicationPool applicationPool)
        {
            throw new NotImplementedException();
        }

        public void StartApplicationPool(ApplicationPool applicationPool)
        {
            throw new NotImplementedException();
        }

        public void StopApplicationPool(ApplicationPool applicationPool)
        {
            throw new NotImplementedException();
        }
    }
}
