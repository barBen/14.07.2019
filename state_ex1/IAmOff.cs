using System;

namespace State
{
    public class IAmOff : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off...");
            return new IAmBroken();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }

        public ILightState Fix()
        {
            Console.WriteLine("nothing to fix");
            return this;
        }
    }
}
