using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor_v2
{
    public abstract class FormolaBase : IFormola
    {

        protected IFormola formola;

        public abstract string GetFormola();

        public abstract double GetResult();

        public FormolaBase(IFormola formola)
        {
            this.formola = formola;
        }

    }
}
