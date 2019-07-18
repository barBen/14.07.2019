using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class SemiReflectionDecoration : WindowDecoratorBase
    {
        public SemiReflectionDecoration(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + ", semi reflection";
        }
    }
}
