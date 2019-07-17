using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            menu.Add(new VeggHamburgerBuilder());
            menu.Add(new MeatburgerBuilder());
            menu.Add(new VeggHambBuilderLettuce());

            Hamburger hamb = PrepareHamburger(menu[0]);

            //////////////////////////////////////////////////////////////

            HumburgerFactory factory = new HumburgerFactory();

            Hamburger hums1 = new Hamburger();
            hums1 = factory.createHamburger("veg");

            Console.WriteLine(hums1);


            Hamburger hums2 = new Hamburger();
            hums2 = factory.createHamburger("meat");

            Console.WriteLine(hums2);
        }

        static Hamburger PrepareHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();
        }
    }
}
