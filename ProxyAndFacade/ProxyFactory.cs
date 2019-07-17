using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class ProxyFactory
    {
        public ClientProxy login(string user, string pass)
        {
            if (user.Equals("cus") && pass.Equals("123"))
            {
                return new CustomerProxy();
            }
            if (user.Equals("comp") && pass.Equals("123"))
            {
                return new CompanyProxy();
            }
            if (user.Equals("admin") && pass.Equals("123"))
            {
                return new AdminProxy();
            }

            return null;
        }

    }
}
