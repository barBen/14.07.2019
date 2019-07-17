using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RemoteControle
    {
        DeviceBase device;

        public RemoteControle(DeviceBase device)
        {
            this.device = device;
        }

        public void on()
        {
            device.turnOn();
        }

        public void off()
        {
            device.turnOff();
        }

        public void next()
        {
            device.pressNext();
        }

        public void prev()
        {
            device.pressPrev();
        }

        public void printStaus()
        {
            device.printStatus();
        }
    }
}
