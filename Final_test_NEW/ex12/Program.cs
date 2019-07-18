using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputerFactory factory = new ComputerFactory();
            Console.WriteLine("WORK: " + factory.createComputer("work"));
            Console.WriteLine("GAME: " + factory.createComputer("game"));
            Console.WriteLine("LIVING ROOM: " + factory.createComputer("living room"));
        }
    }
}
