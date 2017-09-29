using System;

namespace PB_January_2016_4_Master_Herbalist
{
    class MasterHerbalist
    {
        static void Main(string[] args)
        {
            long dailyExpenses = long.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            decimal moneyTotal = 0;
            long days = 0;

            while (input != "Season Over")
            {
                string[] split = input.Split();
                long hours = long.Parse(split[0]);
                string path = split[1];
                long price = long.Parse(split[2]);
                long herbs = 0;

                for (int i = 0; i < hours; i++)
                {
                    if (path[i % path.Length] == 'H')
                    {
                        herbs++;
                    }
                }

                days++;
                moneyTotal += herbs * price;

                input = Console.ReadLine();
            }

            decimal averageEarnings = Math.Round((moneyTotal / days), 2);
            if (averageEarnings >= dailyExpenses)
            {
                decimal moneyExtra = averageEarnings - dailyExpenses;
                Console.WriteLine($"Times are good. Extra money per day: {moneyExtra:f2}.");
            }
            else
            {
                decimal moneyNeeded = (dailyExpenses * days) - moneyTotal;
                Console.WriteLine($"We are in the red. Money needed: {moneyNeeded:f0}.");
            }
        }
    }
}