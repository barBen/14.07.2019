using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    public class Div : FormolaBase
    {
        private double divNum;

        public Div(IFormola formola, double toDiv) : base(formola)
        {
            this.divNum = toDiv;
        }

        public override string GetFormola()
        {
            return formola.GetFormola() + " / " + this.divNum;
        }

        public override double GetResult()
        {
            return formola.GetResult() / this.divNum;
        }
    }
}
