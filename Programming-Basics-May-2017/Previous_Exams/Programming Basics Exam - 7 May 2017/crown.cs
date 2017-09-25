using System;

namespace PB_May_2017_5_Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (2 * n) - 1;
            int height = (n / 2) + 4;

            // First two rows
            string space = new string(' ', n - 2);
            Console.WriteLine($"@{space}@{space}@");
            space = new string(' ', n - 3);
            Console.WriteLine($"**{space}*{space}**");

            // Mid rows (n / 2) - 2
            int dotsLRCount = 1;
            string dotsLR = new string('.', dotsLRCount);
            int dotsMidCount = 1;
            string dotsMid = new string('.', dotsMidCount);
            int spaceCount = (width / 2) - 4;

            for (int i = 0; i < (n / 2) - 2; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);
                space = new string(' ', spaceCount);

                Console.WriteLine($"*{dotsLR}*{space}*{dotsMid}*{space}*{dotsLR}*");

                dotsLRCount++;
                dotsMidCount += 2;
                spaceCount -= 2;
            }

            // Next two rows
            dotsLR = new string('.', dotsLRCount);
            dotsMid = new string('.', dotsMidCount);
            Console.WriteLine($"*{dotsLR}*{dotsMid}*{dotsLR}*");

            dotsLRCount++;
            dotsLR = new string('.', dotsLRCount);
            int starsCount = ((width - 3) - (dotsLRCount * 2)) / 2;
            string stars = new string('*', starsCount);
            Console.WriteLine($"*{dotsLR}{stars}.{stars}{dotsLR}*");

            // Last two rows
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}