using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{ 
    public class Add : FormolaBase
    {
        private double addNum;

        public Add(IFormola formola, double toAdd) : base(formola)
        {
            this.addNum = toAdd;
        }

        public override string GetFormola()
        {
            return formola.GetFormola() + " + " + this.addNum;
        }

        public override double GetResult()
        {
            return formola.GetResult() + this.addNum;
        }
    }
}
