using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace IISEasyManager.Interfaces
{
    public interface ILocalAppPool
    {
        List<string> GetLocalAppPools();
        void RestartApplicationPool(ApplicationPool applicationPool);
        void StartApplicationPool(ApplicationPool applicationPool);
        void StopApplicationPool(ApplicationPool applicationPool);


    }
}
