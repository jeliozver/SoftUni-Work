using System;

namespace PB_January_2016_2_Beer_Stock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            int beersReserved = int.Parse(Console.ReadLine());
            string shipment = Console.ReadLine();

            long beersCount = 0;

            while (shipment != "Exam Over")
            {
                string[] parameters = shipment.Split();
                long amount = long.Parse(parameters[0]);
                string type = parameters[1];

                if (type == "beers")
                {
                    beersCount += amount;
                }
                else if (type == "cases")
                {
                    beersCount += amount * 24;
                }
                else if (type == "sixpacks")
                {
                    beersCount += amount * 6;
                }

                shipment = Console.ReadLine();
            }

            if (beersCount >= 100)
            {
                beersCount = beersCount - (beersCount / 100);
            }

            if (beersCount >= beersReserved)
            {
                long beersLeft = beersCount - beersReserved;
                long cases = beersLeft / 24;
                beersLeft = beersLeft % 24;
                long sixpacks = beersLeft / 6;
                beersLeft = beersLeft % 6;
                Console.WriteLine($"Cheers! Beer left: {cases} cases, {sixpacks} " +
                    $"sixpacks and {beersLeft} beers.");
            }
            else
            {
                long beersNeeded = beersReserved - beersCount;
                long cases = beersNeeded / 24;
                beersNeeded = beersNeeded % 24;
                long sixpacks = beersNeeded / 6;
                beersNeeded = beersNeeded % 6;
                Console.WriteLine($"Not enough beer. Beer needed: {cases} cases, " +
                    $"{sixpacks} sixpacks and {beersNeeded} beers.");
            }
        }
    }
}