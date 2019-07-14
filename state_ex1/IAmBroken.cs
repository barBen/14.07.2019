using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Im broken");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Im broken");
            return this;
        }

        public ILightState Fix()
        {
            Console.WriteLine("Fix the light! The light now is turn off..");
            return new IAmOff() ;
        }
    }
}
