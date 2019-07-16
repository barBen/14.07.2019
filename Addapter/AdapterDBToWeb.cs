using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterDBToWeb : IDBWebData
    {

        IDBData dbData = new PerfectStore();

        public void store(WebClientData webClientData)
        {
            dbData.store(webClientData.getClientData());
        }
    }
}
