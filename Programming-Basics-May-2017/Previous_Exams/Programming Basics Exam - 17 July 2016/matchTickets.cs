using System;

namespace PB_July_2016_3_Match_Tickets
{
    class matchTickets
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            decimal transport = 0.00m;
            decimal ticketsPrice = 0.00m;

            if (people >= 50)
            {
                transport = budget * 0.25m;
            }
            else if (people >= 25 && people < 50)
            {
                transport = budget * 0.40m;
            }
            else if (people >= 10 && people < 25)
            {
                transport = budget * 0.50m;
            }
            else if (people >= 5 && people < 10)
            {
                transport = budget * 0.60m;
            }
            else if (people >= 1 && people < 5)
            {
                transport = budget * 0.75m;
            }

            if (category == "vip")
            {
                ticketsPrice = 499.99m * people;
                if (budget - transport > ticketsPrice)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - transport) - ticketsPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", ticketsPrice - (budget - transport));
                }
            }
            else if (category == "normal")
            {
                ticketsPrice = 249.99m * people;
                if (budget - transport > ticketsPrice)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - transport) - ticketsPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", ticketsPrice - (budget - transport));
                }
            }
        }
    }
}
