using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClientData webData = new WebClientData("blalal", 12, "127.0.0.1", true);

            storeClient(new AdapterDBToWeb(), webData);
        }

        // non mutable
        private static void storeClient(IDBWebData webData, WebClientData webClientData)
        {
            webData.store(webClientData);
        }
    }
}
