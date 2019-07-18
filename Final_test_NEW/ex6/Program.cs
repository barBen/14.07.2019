using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            VeryHeavyNumber BigNum = HeavyNumberFactory.GetVeryHeavynumber("13,11");
            Console.WriteLine(BigNum.GetResult());
            VeryHeavyNumber BigNum2 = HeavyNumberFactory.GetVeryHeavynumber("2,3");
            Console.WriteLine(BigNum2.GetResult());
            VeryHeavyNumber BigNum3 = HeavyNumberFactory.GetVeryHeavynumber("13,11");
            Console.WriteLine(BigNum.GetResult());
            VeryHeavyNumber BigNum4 = HeavyNumberFactory.GetVeryHeavynumber("7,2");
            Console.WriteLine(BigNum4.GetResult());
        }
    }
}
