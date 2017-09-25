using System;

namespace PB_NovM_2016_2_Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodAmount = int.Parse(Console.ReadLine());
            double dogEatKg = double.Parse(Console.ReadLine());
            double catEatKg = double.Parse(Console.ReadLine());
            double turtleEatGr = double.Parse(Console.ReadLine());

            double dogNeed = days * dogEatKg;
            double catNeed = days * catEatKg;
            double turtleNeed = (days * turtleEatGr) / 1000;
            double foodRqr = dogNeed + catNeed + turtleNeed;

            if (foodRqr <= foodAmount)
            {
                double foodLeft = Math.Floor(foodAmount - foodRqr);
                Console.WriteLine("{0} kilos of food left.", foodLeft);
            }
            else
            {
                double foodNeed = Math.Ceiling(foodRqr - foodAmount);
                Console.WriteLine("{0} more kilos of food are needed.", foodNeed);
            }
        }
    }
}