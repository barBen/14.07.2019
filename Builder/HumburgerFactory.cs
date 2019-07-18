using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class HumburgerFactory
    {
        public Hamburger createHamburger(string newHamburger)
        {
            switch (newHamburger)
            {
                case ("veg"):
                    {
                        VeggHamburgerBuilder vegBurger = new VeggHamburgerBuilder();
                        vegBurger.BuildHamburger();
                        return vegBurger.GetHamburger();
                    }
                case ("meat"):
                    {
                        MeatburgerBuilder meatBurger = new MeatburgerBuilder();
                        meatBurger.BuildHamburger();
                        return meatBurger.GetHamburger();
                    }
                case ("Lettuce"):
                    {
                        VeggHambBuilderLettuce LettuceBurger = new VeggHambBuilderLettuce();
                        LettuceBurger.BuildHamburger();
                        return LettuceBurger.GetHamburger();
                    }
                default:
                    throw new HamburgerNotReadyException("Hamburger doent exsit."); ; 
            }
        }
    }
}
