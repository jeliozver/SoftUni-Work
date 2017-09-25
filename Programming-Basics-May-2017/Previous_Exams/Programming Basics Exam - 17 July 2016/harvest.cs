using System;

namespace PB_July_2016_2_Harvest
{
    class harvest
    {
        static void Main(string[] args)
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapeKgPerSqm = double.Parse(Console.ReadLine());
            double litersWineSale = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapeAmount = vineyardArea * grapeKgPerSqm;
            double litersWine = (grapeAmount * 0.40) / 2.5;

            if (litersWine < litersWineSale)
            {
                double litersRequired = litersWineSale - litersWine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", 
                    Math.Truncate(litersRequired));
            }
            else
            {
                double litersLeft = litersWine - litersWineSale;
                double litersPerWorker = litersLeft / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", 
                    Math.Truncate(litersWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", 
                    Math.Ceiling(litersLeft), Math.Ceiling(litersPerWorker));
            }
        }
    }
}
