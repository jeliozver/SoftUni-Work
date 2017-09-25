using System;

namespace PB_Sep_2_2017_5_Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;
            int exesCount = n;
            int dotsCount = ((width - 1) - (2 * n)) / 2;

            // First 3 lines
            Console.WriteLine("{0}x{0}",
                new string('.', (width - 1) / 2));
            Console.WriteLine("{0}/x\\{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x|x{0}",
                new string('.', (width - 3) / 2));

            // Top
            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount--;
                exesCount++;
            }

            dotsCount = 1;
            exesCount = (width - 3) / 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount++;
                exesCount--;
            }

            // Midddle
            Console.WriteLine("{0}/x\\{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}",
                new string('.', (width - 3) / 2));

            // Bottom
            exesCount = n;
            dotsCount = ((width - 1) - (2 * n)) / 2;

            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount--;
                exesCount++;
            }

            dotsCount = 1;
            exesCount = (width - 3) / 2;
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dotsCount),
                    new string('x', exesCount));

                dotsCount++;
                exesCount--;
            }

            // Last 3 lines
            Console.WriteLine("{0}x|x{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}",
                new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}",
                new string('.', (width - 1) / 2));
        }
    }
}