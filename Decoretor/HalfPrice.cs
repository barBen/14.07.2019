using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HalfPrice : ToppingDecoratorBase
    {
        public HalfPrice(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " IN HALF PRICE";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() * 0.5;
        }
    }
}
