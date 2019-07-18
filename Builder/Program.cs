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

            Hamburger hamb = PrepareHamburger(menu[2]);

            Console.WriteLine(hamb);

            //////////////////////////////////////////////////////////////

            HumburgerFactory factory = new HumburgerFactory();

            List<Hamburger> hums = new List<Hamburger>();
            hums.Add(factory.createHamburger("veg"));
            hums.Add(factory.createHamburger("meat"));

            foreach (var hum in hums)
            {
                Console.WriteLine(hum);
            }
        }

        static Hamburger PrepareHamburger(HamburgerBuilder builder)
        {
            builder.BuildHamburger();
            return builder.GetHamburger();
        }
    }
}
