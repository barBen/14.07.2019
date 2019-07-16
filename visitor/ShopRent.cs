using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class ShopRent : IVisitable
    {

        public double Price { get; set; }

        public ShopRent(double price)
        {
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"ShopRent price : {Price}";
        }
    }
}
