using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void store(ClientData clientData)
        {
            Console.WriteLine($"the client data is: {clientData}");
        }
    }
}
