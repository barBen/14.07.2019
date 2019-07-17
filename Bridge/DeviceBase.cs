using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class DeviceBase
    {
        protected bool isOn;
        protected int state;
        protected int max;

        public DeviceBase(int max)
        {
            this.max = max;
        }

        public abstract void printStatus();

        public abstract void pressNext();

        public abstract void pressPrev();

        public void turnOn()
        {
            Console.WriteLine("Turn on");
            this.isOn = true;
        }

        public void turnOff()
        {
            Console.WriteLine("turn off");
            this.isOn = false;
        }
    }
}
