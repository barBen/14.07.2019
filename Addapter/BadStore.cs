using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // non touchable class
    // 3rd party
    // very old - chanigng it will be danger ....
    public class BadStore : IDBWebData
    {
        public void store(WebClientData webclientData)
        {
            Console.WriteLine($"bad client data: {webclientData}");
        }
    }
}
