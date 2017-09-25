using System;

namespace PB_MarchE_2_2017_1_Grape_Rakia
{
    class GrapeAndRakiya
    {
        static void Main(string[] args)
        {
            double vineyardArea = double.Parse(Console.ReadLine());
            double grapeKgPerSqm = double.Parse(Console.ReadLine());
            double spoilage = double.Parse(Console.ReadLine());

            double grapeKgTotal = (vineyardArea * grapeKgPerSqm) - spoilage;
            double grapeForRakiya = grapeKgTotal * 0.45;
            double rakiyaLiters = grapeForRakiya / 7.5;
            double rakiyaIncome = rakiyaLiters * 9.80;

            double grapeForSale = grapeKgTotal * 0.55;
            double grapeIncome = grapeForSale * 1.50;
        
            Console.WriteLine("{0:F2}", rakiyaIncome);
            Console.WriteLine("{0:F2}", grapeIncome);
        }
    }
}
