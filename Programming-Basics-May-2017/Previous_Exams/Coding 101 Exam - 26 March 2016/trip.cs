using System;

namespace PB_March_2_2016_3_Trip
{
    class trip
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            decimal budgetSpent = 0.0m;
            string place = "";

            if (budget > 1000)
            {
                place = "Hotel";
                budgetSpent = budget * 0.90m;

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("{0} - {1:f2}", place, budgetSpent);
            }
            else if (budget <= 1000 && budget > 100)
            {
                if (season == "winter")
                {
                    place = "Hotel";
                    budgetSpent = budget * 0.80m;

                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("{0} - {1:f2}", place, budgetSpent);
                }
                else
                {
                    place = "Camp";
                    budgetSpent = budget * 0.40m;

                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("{0} - {1:f2}", place, budgetSpent);
                }
            }
            else if (budget <= 100 && budget >= 10)
            {
                if (season == "winter")
                {
                    place = "Hotel";
                    budgetSpent = budget * 0.70m;

                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("{0} - {1:f2}", place, budgetSpent);
                }
                else
                {
                    place = "Camp";
                    budgetSpent = budget * 0.30m;

                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("{0} - {1:f2}", place, budgetSpent);
                }
            }
        }
    }
}
