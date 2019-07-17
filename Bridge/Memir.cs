using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Memir : DeviceBase
    {
        public Memir(int max) : base(max)
        {
        }

        public override void pressNext()
        {
            if (this.isOn)
            {
                if (this.state < this.max)
                {
                    this.state++;
                    Console.WriteLine($"memir - press next to state: {this.state}");
                }
                else
                    Console.WriteLine("memir - You in the max state.");
            }
            else
            {
                Console.WriteLine("memir is OFF - cant change state.");
            }
        }

        public override void pressPrev()
        {
            if (this.isOn)
            {
                if (this.state > 1)
                {
                    this.state--;
                    Console.WriteLine($"memir - press prev to state: {this.state}");
                }
                else
                    Console.WriteLine("memir - You in the min state.");
            }
            else
            {
                Console.WriteLine("memir is OFF - cant change state.");
            }
        }

        public override void printStatus()
        {
            if (this.isOn)
                Console.WriteLine($"memir is ON. memir state: { this.state} ");
            else
                Console.WriteLine($"memir is OFF. memir state: { this.state} ");
        }
    }
}
