using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MeatburgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("White flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("red meat");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Fat cream");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 80 ILS");
        }
    }
}
