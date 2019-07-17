using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class CompanyProxy : ClientProxy, ICompany
    {
        public void createFlight()
        {
            this.facade.createFlight();
        }

        public void cancelFlight()
        {
            this.facade.cancelFlight();
        }
    }
}
