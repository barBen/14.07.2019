using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    public class Sub : FormolaBase
    {
        private double subNum;

        public Sub(IFormola formola, double toSub) : base(formola)
        {
            this.subNum = toSub;
        }

        public override string GetFormola()
        {
            return formola.GetFormola() + " - " + this.subNum;
        }

        public override double GetResult()
        {
            return formola.GetResult() - this.subNum;
        }
    }
}
