using System;

namespace PB_MarchM_2_2017_2_Cups
{
    class cups
    {
        static void Main(string[] args)
        {
            int cupsPlanned = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int daysWorking = int.Parse(Console.ReadLine());

            double cupsPlannedPrice = cupsPlanned * 4.20;
            double hoursWorking = workers * (daysWorking * 8);
            double cupsDone = Math.Floor(hoursWorking / 5);
            double cupsDonePrice = cupsDone * 4.20;

            if (cupsDonePrice >= cupsPlannedPrice)
            {
                Console.WriteLine("{0:f2} extra money", cupsDonePrice - cupsPlannedPrice);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", cupsPlannedPrice - cupsDonePrice);
            }
        }
    }
}
