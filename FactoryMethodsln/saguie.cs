using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Saguie : Vehicle
    {

        protected string name;

        public Saguie(string model, float cylinder, string color, int numberOfWheels, string name) : base(model, cylinder, color, numberOfWheels)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Saguie : " + base.ToString() + $" { name}";
        }
    }
}