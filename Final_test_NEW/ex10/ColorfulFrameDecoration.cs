using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class ColorfulFrameDecoration : WindowDecoratorBase
    {
        public ColorfulFrameDecoration(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + ", colorful frame";
        }
    }
}
