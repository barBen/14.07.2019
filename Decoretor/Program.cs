using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasePizza();

            IPizza pizzaWithTomato = new TomatoTopping(pizza);
            IPizza pizzaWithTomatoAndPineapple = new PineaappleTopping(pizzaWithTomato);
            IPizza pizzaWithTomatoAndPineappleAndCorn = new CornTopping(pizzaWithTomatoAndPineapple);

            Console.WriteLine(pizzaWithTomatoAndPineappleAndCorn.GetDetails());
            Console.WriteLine(pizzaWithTomatoAndPineappleAndCorn.GetPrice());

            Console.WriteLine("=====================================================");

            IPizza halfPrice = new HalfPrice(pizzaWithTomatoAndPineappleAndCorn);
            Console.WriteLine(halfPrice.GetDetails());
            Console.WriteLine(halfPrice.GetPrice());

            IPizza myfavoritePizza = new TomatoTopping(new CheeseTopping(new BasePizza()));

        }
    }
}
