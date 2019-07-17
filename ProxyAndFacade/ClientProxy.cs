using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    abstract class ClientProxy 
    {
        protected FlightSystemFacade facade = new FlightSystemFacade();
    }
}
