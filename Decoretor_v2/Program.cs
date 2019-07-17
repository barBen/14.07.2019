using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNumber f = new StartNumber(10);
            IFormola add = new Add(f, 5);
            IFormola mul = new Mul(add, 3);
            IFormola add2 = new Add(mul, 4);

            Console.WriteLine(add2.GetFormola());
            Console.WriteLine(add2.GetResult());

            f.modifyNumber(11);
            Console.WriteLine(add2.GetFormola());
            Console.WriteLine(add2.GetResult());
        }
    }
}
