using System;

namespace PB_Sep_2017_5_Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;
            int height = 2 * n + 1;

            int dotsLRCount = 1;
            int dotsMidCount = n - 1;
         
            string dotsLR = new string('.', dotsLRCount);
            string dotsMid = new string('.', dotsMidCount);

            // Top line
            Console.WriteLine("*{0}*{0}*", new string('.', n));

            //Top
            for (int row = 1; row <= n - 2; row++)
            {
                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);

                Console.WriteLine($"{dotsLR}*{dotsMid}*{dotsMid}*{dotsLR}");

                dotsLRCount++;
                dotsMidCount--;
            }

            // Middle (3 lines)
            dotsLR = new string('.', dotsLRCount);
            Console.WriteLine($"{dotsLR}*****{dotsLR}");
            Console.WriteLine(new string('*', width));
            Console.WriteLine($"{dotsLR}*****{dotsLR}");

            // Bottom
            for (int row = 1; row <= n - 2; row++)
            {
                dotsLRCount--;
                dotsMidCount++;

                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);

                Console.WriteLine($"{dotsLR}*{dotsMid}*{dotsMid}*{dotsLR}");
            }

            // Bottom line
            Console.WriteLine("*{0}*{0}*", new string('.', n));
        }
    }
}