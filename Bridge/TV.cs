using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class TV : DeviceBase
    {
        public TV(int max) : base(max)
        {
        }

        public override void pressNext()
        {
            if (this.isOn)
            {
                if (this.state < this.max)
                {
                    this.state++;
                    Console.WriteLine($"TV - press next to state: {this.state}");
                }
                else
                    Console.WriteLine("TV - You in the max state.");
            }
            else
            {
                Console.WriteLine("TV is OFF - cant change state.");
            }
        }

        public override void pressPrev()
        {
            if (this.isOn)
            {
                    if (this.state > 1)
                {
                    this.state--;
                    Console.WriteLine($"TV - press prev to state: {this.state}");
                }
                else
                    Console.WriteLine("TV - You in the min state.");
            }
            else
            {
                Console.WriteLine("TV is OFF - cant change state.");
            }
        }

        public override void printStatus()
        {
            if (this.isOn)
                Console.WriteLine($"TV is ON. TV state: { this.state} ");
            else
                Console.WriteLine($"TV is OFF. TV state: { this.state} ");
        }
    }
}
