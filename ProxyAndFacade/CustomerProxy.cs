using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class CustomerProxy : ClientProxy, ICustomer
    {
        public void buyTicket()
        {
            this.facade.buyTicket();
        }

        public void showMyTikcet()
        {
            this.facade.showMyTikcet();
        }
    }
}
