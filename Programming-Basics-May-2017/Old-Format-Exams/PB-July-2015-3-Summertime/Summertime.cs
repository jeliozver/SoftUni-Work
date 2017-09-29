using System;

namespace PB_July_2015_3_Summertime
{
    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widthTop = n + 1;
            int widthBottom = 2 * n;
            int height = 3 * n + 1;

            // Top
            string stars = new string('*', widthTop);
            Console.WriteLine($"{stars}");

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                string spacesMid = new string(' ', widthTop - 2);
                string spacesLeft = new string(' ', (n - 1) / 2);
                Console.WriteLine($"{spacesLeft}*{spacesMid}*");
            }

            int spacesMidCount = widthTop;
            int spacesLeftCount = (n - 1) / 2 - 1;

            for (int row = 1; row <= (n + 1) / 2 - 2; row++)
            {
                string spacesMid = new string(' ', spacesMidCount);
                string spacesLeft = new string(' ', spacesLeftCount);
                Console.WriteLine($"{spacesLeft}*{spacesMid}*");

                spacesLeftCount--;
                spacesMidCount += 2;
            }

            // Bottom
            for (int row = 1; row <= n; row++)
            {
                string dots = new string('.', widthBottom - 2);
                Console.WriteLine($"*{dots}*");
            }

            for (int row = 1; row <= n; row++)
            {
                string monkeys = new string('@', widthBottom - 2);
                Console.WriteLine($"*{monkeys}*");
            }

            Console.WriteLine("{0}", new string('*', widthBottom));
        }
    }
}