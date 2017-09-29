using System;

namespace PB_January_2016_1_Cake_Tycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            ulong cakes = ulong.Parse(Console.ReadLine());
            decimal flourOneCake = decimal.Parse(Console.ReadLine());
            long flour = long.Parse(Console.ReadLine());
            long truffles = long.Parse(Console.ReadLine());
            long trufflePrice = long.Parse(Console.ReadLine());

            decimal cakesPossible = Math.Floor(flour / flourOneCake);

            if (cakesPossible >= cakes)
            {
                decimal trufflesCost = truffles * trufflePrice;
                decimal cakePrice = Math.Round((trufflesCost / cakes) * 1.25m, 2);

                Console.WriteLine($"All products available, price of a cake: {cakePrice}");
            }
            else
            {
                decimal totalFlourReq = cakes * flourOneCake;
                decimal flourNeed = Math.Round(totalFlourReq - flour, 2);

                Console.WriteLine($"Can make only {cakesPossible} cakes, need {flourNeed} kg more flour");
            }
        }
    }
}