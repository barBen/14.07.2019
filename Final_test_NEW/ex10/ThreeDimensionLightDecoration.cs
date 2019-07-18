using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class ThreeDimensionLightDecoration : WindowDecoratorBase
    {
        public ThreeDimensionLightDecoration(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + ", 3DLight";
        }
    }
}
