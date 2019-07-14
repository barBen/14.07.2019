using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Track : Vehicle
    {

        protected string WheelsSize;

        public Track(string model, float cylinder, string color, int numberOfWheels, string WheelsSize) : base(model, cylinder, color, numberOfWheels)
        {
            this.WheelsSize = WheelsSize;
        }

        public override string ToString()
        {
            return "Track : " + base.ToString() + $" { WheelsSize}";
        }
    }
}