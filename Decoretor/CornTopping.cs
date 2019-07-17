using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CornTopping : ToppingDecoratorBase
    {
        public CornTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " Corn";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 3;
        }
    }
}
