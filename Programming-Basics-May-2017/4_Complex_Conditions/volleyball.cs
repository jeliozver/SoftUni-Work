using System;

namespace Volleyball
{
    class volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            double weekendsHome = int.Parse(Console.ReadLine());

            double gamesSofiyaSat = (48 - weekendsHome) * 3 / 4;
            double gamesSofiyaHol = holidays * 2 / 3;
            double gamesTotal = gamesSofiyaSat + gamesSofiyaHol + weekendsHome;

            if (yearType == "leap")
            {
                gamesTotal = gamesTotal + (gamesTotal * 0.15);
                Console.WriteLine(Math.Floor(gamesTotal));
            }
            else
            {
                Console.WriteLine(Math.Floor(gamesTotal));
            }
        }
    }
}
