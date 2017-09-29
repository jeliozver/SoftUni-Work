using System;

namespace PB_February_2016_1_Hungry_Garfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());

            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());

            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            decimal moneyNeeded = (pizzaPrice / usdRate * pizzaQuantity) +
                                 (lasagnaPrice / usdRate * lasagnaQuantity) +
                                 (sandwichPrice / usdRate * sandwichQuantity);

            if (money >= moneyNeeded)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. " +
                    $"Money left: ${money - moneyNeeded:f2}.");
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. " +
                    $"Money needed: ${Math.Abs(money - moneyNeeded):f2}.");
            }
        }
    }
}