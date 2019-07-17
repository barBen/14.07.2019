using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory();
            ClientProxy admin = factory.login("admin", "123");
            Console.WriteLine("admin");
            ((AdminProxy)admin).createCompany();
            ((AdminProxy)admin).createCostumer();
            Console.WriteLine("========================================= \ncustomer");
            ClientProxy cus = factory.login("cus", "123");
            ((CustomerProxy)cus).buyTicket();
            ((CustomerProxy)cus).showMyTikcet();
        }
    }
}
