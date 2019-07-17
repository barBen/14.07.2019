using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class AdminProxy : ClientProxy, IAdmin
    {
        public void createCompany()
        {
            this.facade.createCompany();
        }

        public void createCostumer()
        {
            this.facade.createCostumer();
        }
    }
}
