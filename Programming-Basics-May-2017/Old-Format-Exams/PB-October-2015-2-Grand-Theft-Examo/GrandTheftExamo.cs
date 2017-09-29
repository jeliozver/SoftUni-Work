using System;

namespace PB_October_2015_2_Grand_Theft_Examo
{
    class GrandTheftExamo
    {
        static void Main(string[] args)
        {
            int escapeAttempts = int.Parse(Console.ReadLine());

            long thievesSlappedSum = 0;
            long thievesEscapedSum = 0;

            long beerBottles = 0;

            for (int i = 1; i <= escapeAttempts; i++)
            {
                long thieves = long.Parse(Console.ReadLine());
                long beer = long.Parse(Console.ReadLine());

                if (thieves > 5)
                {
                    thievesEscapedSum += thieves - 5;
                    thievesSlappedSum += 5;
                    beerBottles += beer;
                }
                else
                {
                    thievesSlappedSum += thieves;
                    beerBottles += beer;
                }
            }

            long sixpacks = beerBottles / 6;
            beerBottles = beerBottles % 6;

            Console.WriteLine($"{thievesSlappedSum} thieves slapped.");
            Console.WriteLine($"{thievesEscapedSum} thieves escaped.");
            Console.WriteLine($"{sixpacks} packs, {beerBottles} bottles.");
        }
    }
}