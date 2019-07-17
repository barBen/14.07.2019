using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class FlightDAO
    {
        public void insertTicket()
        {
            Console.WriteLine("inserting ticket");
        }

        public void getMyTicket()
        {
            Console.WriteLine("get ticket");
        }

        public void insertFlight()
        {
            Console.WriteLine("inserting flight");
        }

        public void removeFlight()
        {
            Console.WriteLine("remove flight");
        }
        public void insertCustomer()
        {
            Console.WriteLine("inserting customer");
        }

        public void insertCompany()
        {
            Console.WriteLine("inserting company");
        }
    }
}
