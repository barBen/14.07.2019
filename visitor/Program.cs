using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);
            Perfume calvin = new Perfume(200);
            ShopRent shop = new ShopRent(1000000000);

            Console.WriteLine(vodka);
            Console.WriteLine(calvin);
            Console.WriteLine(shop);

            IVisitor endOfYearVisitor = new EndOfYearTax();
            IVisitor oneShekelSale = new OneShekelSale();

            Console.WriteLine($"VODKA Price after tax = {vodka.Accept(endOfYearVisitor)}");
            Console.WriteLine($"CALVIN Price after tax = {calvin.Accept(endOfYearVisitor)}");
            Console.WriteLine($"SHOP Price after tax = {shop.Accept(endOfYearVisitor)}");
            Console.WriteLine($"VODKA 1 shekel price = {vodka.Accept(oneShekelSale)}");
            Console.WriteLine($"CALVIN 1 shekel price= {calvin.Accept(oneShekelSale)}");
            Console.WriteLine($"SHOP 1 shekel price= {shop.Accept(oneShekelSale)}");
        }
    }
}
