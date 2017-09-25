using System;

namespace PB_NovE_2016_2_Flower_Shop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int zymbiuls = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double tax = 0.05;
            double profit = (magnolias * 3.25) + (zymbiuls * 4) + (roses * 3.50) + (cactuses * 8);
            double profitTotal = profit - (profit * tax);

            if (profitTotal >= presentPrice)
            {
                double moneyLeft = profitTotal - presentPrice;
                Console.WriteLine("She is left with {0} leva.", Math.Floor(moneyLeft));
            }
            else
            {
                double moneyRequired = presentPrice - profitTotal;
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(moneyRequired));
            }
        }
    }
}