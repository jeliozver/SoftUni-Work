using System;

namespace PB_Sep_2_2017_4_Grandpa_Stavri
{
    class GrandpaStavri
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double litersTotal = 0.00;
            double degreesTotal = 0.00;

            for (int i = 1; i <= days; i++)
            {
                double rakiyaQuantity = double.Parse(Console.ReadLine());
                double rakiyaDegrees = double.Parse(Console.ReadLine());

                litersTotal += rakiyaQuantity;
                if (i == 1)
                {
                    degreesTotal = rakiyaQuantity * rakiyaDegrees;
                }
                else
                {
                    degreesTotal = degreesTotal + rakiyaDegrees * rakiyaQuantity;
                }
            }

            degreesTotal = degreesTotal / litersTotal;

            Console.WriteLine($"Liter: {litersTotal:f2}");
            Console.WriteLine($"Degrees: {degreesTotal:f2}");

            if (degreesTotal > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
            else if (degreesTotal >= 38 && degreesTotal <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Not good, you should baking!");
            }
        }
    }
}