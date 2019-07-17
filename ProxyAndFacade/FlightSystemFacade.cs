using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndFacade
{
    class FlightSystemFacade : IAdmin, ICompany
    {
        FlightDAO dao = new FlightDAO();

        public void buyTicket()
        {
            dao.insertTicket();
        }

        public void cancelFlight()
        {
            dao.removeFlight();
        }

        public void createCompany()
        {
            dao.insertCompany();
        }

        public void createCostumer()
        {
            dao.insertCustomer();
        }

        public void createFlight()
        {
            dao.insertFlight();
        }

        public void showMyTikcet()
        {
            dao.insertTicket();
        }
    }
}
