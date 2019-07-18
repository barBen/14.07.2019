using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public class VeryHeavyNumber
    {
        public int baseNum;
        public int powerNum;


        public VeryHeavyNumber(int baseNum, int powerNum)
        {
            this.baseNum = baseNum;
            this.powerNum = powerNum;
        }

        public double GetResult()
        {
            return Math.Pow(Convert.ToDouble(baseNum), Convert.ToDouble(powerNum));
        }
    }
}
