using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    public class Mul : FormolaBase
    {
        private double mulNum;

        public Mul(IFormola formola, double toMul) : base(formola)
        {
            this.mulNum = toMul;
        }

        public override string GetFormola()
        {
            return formola.GetFormola() + " * " + this.mulNum;
        }

        public override double GetResult()
        {
            return formola.GetResult() * this.mulNum;
        }
    }
}
