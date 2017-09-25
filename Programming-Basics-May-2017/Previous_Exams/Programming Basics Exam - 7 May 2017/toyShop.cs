using System;

namespace PB_May_2017_2_Toy_Shop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            int numTotal = numPuzzles + numDolls + numBears + numMinions + numTrucks;
            double profitPuzzles = numPuzzles * 2.60;
            double profitDolls = numDolls * 3;
            double profitBears = numBears * 4.10;
            double profitMinions = numMinions * 8.20;
            double profitTrucks = numTrucks * 2;
            double profitTotal = profitPuzzles + profitDolls + profitBears + profitMinions + profitTrucks;

            if (numTotal >= 50)
            {
                profitTotal = profitTotal - (profitTotal * 0.25);
                profitTotal = profitTotal - (profitTotal * 0.10);
            }
            else
            {
                profitTotal = profitTotal - (profitTotal * 0.10);
            }

            if (profitTotal >= tripPrice)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", profitTotal - tripPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", tripPrice - profitTotal);
            }
        }
    }
}