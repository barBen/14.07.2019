using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hamburger
    {

        private List<String> ingredients = new List<String>();

        public Hamburger()
        {
            // Cheese
            // prepareBun
            // prepareVegg
            // prepareMain
            // prepareTopping		
            // preparePriceLabel	
        }

        public void PrepareBun(String vegg)
        {
            ingredients.Add(vegg);
        }

        public void PrepareVegg(String vegg)
        {
            ingredients.Add(vegg);
        }

        public void PrepareMain(String main)
        {
            ingredients.Add(main);
        }

        public void PrepareTopping(String topping)
        {
            ingredients.Add(topping);
        }

        public void PreparePriceLabel(String price)
        {
            ingredients.Add(price);
        }

        public override string ToString()
        {
            return $"ingredients: \n  bun: {ingredients[0]} \n  veg: {ingredients[1]} \n  main: {ingredients[2]} \n  topping: {ingredients[3]} \n  price: {ingredients[4]} \n";
        }
    }
}
