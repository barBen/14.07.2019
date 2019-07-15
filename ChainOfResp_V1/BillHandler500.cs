using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class BillHandler500 : BillHandlerBase
    {
        public override void Handle(int amount)
        {
            if (amount == 0)
                return;

            if (amount >= 500)
            {
                Console.WriteLine($"Giving 500 x {amount / 5} bills");
            }

            if (amount % 500 > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % 500);
                }
            }
        }
    }
}