using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    class StartNumber : IFormola
    {
        double number;

        public StartNumber(double startNum)
        {
            this.number = startNum;
        }

        public string GetFormola()
        {
            return $"{this.number}";
        }

        public double GetResult()
        {
            return this.number;
        }

        public void modifyNumber(double startNum)
        {
            this.number = startNum;
        }
    }
}
