using System;

namespace PB_NovE_2016_5_Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;

            int spacesCount = 0;
            string spaces = new string(' ', spacesCount);

            int dotsLRCount = (width - 2 - spacesCount) / 2;
            string dotsLR = new string('.', dotsLRCount);

            // Top rows (n)
            for (int topRow = 1; topRow <= n; topRow++)
            {
                spaces = new string(' ', spacesCount);
                dotsLR = new string('.', dotsLRCount);

                Console.WriteLine($"{dotsLR}/{spaces}\\{dotsLR}");

                spacesCount += 2;
                dotsLRCount--;
            }

            // Connector row
            dotsLRCount++;
            int starsCount = width - (dotsLRCount * 2);
            string stars = new string('*', starsCount);

            Console.WriteLine($"{dotsLR}{stars}{dotsLR}");

            // Mid rows (n * 2)
            for (int midRow = 1; midRow <= n * 2; midRow++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                   new string('.', dotsLRCount),
                   new string('\\', (width - 2) - (dotsLRCount * 2)));
            }

            // Bottom rows (n / 2)
            starsCount -= 2;
            for (int bottomRow = 1; bottomRow <= n / 2; bottomRow++)
            {
                stars = new string('*', starsCount);
                dotsLR = new string('.', dotsLRCount);

                Console.WriteLine($"{dotsLR}/{stars}\\{dotsLR}");

                starsCount += 2;
                dotsLRCount--;
            }
        }
    }
}