using System;

namespace PB_July_2016_5_Diamond
{
    class diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsCount = 3 * n;
            int dotsLRCount = 2 * n / 2;
            int dotsMidCount = 3 * n;

            string star = new string('*', starsCount);
            string dotLR = new string('.', dotsLRCount);
            string dotMid = new string('.', dotsMidCount);

            // Top line
            Console.WriteLine($"{dotLR}{star}{dotLR}");

            // Top
            dotsLRCount = n - 1;
            for (int i = 0; i < n - 1; i++)
            {
                star = new string('*', starsCount);
                dotLR = new string('.', dotsLRCount);
                dotMid = new string('.', dotsMidCount);

                dotsLRCount--;
                dotsMidCount += 2;

                Console.WriteLine($"{dotLR}*{dotMid}*{dotLR}");
            }

            // Mid line
            Console.WriteLine(new string('*', 5 * n));

            // Bottom
            dotsLRCount++;
            dotsMidCount -= 2;
            for (int i = 0; i < n * 2; i++)
            {
                dotLR = new string('.', dotsLRCount);
                dotMid = new string('.', dotsMidCount);

                dotsLRCount++;
                dotsMidCount -= 2;

                Console.WriteLine($"{dotLR}*{dotMid}*{dotLR}");
            }

            // Bottom line
            dotLR = new string('.', dotsLRCount);
            star = new string('*', dotsMidCount + 2);
            Console.WriteLine($"{dotLR}{star}{dotLR}");
        }
    }
}
