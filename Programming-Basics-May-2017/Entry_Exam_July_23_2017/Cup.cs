using System;

namespace _05_Cup
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;

            int dotsLRCount = n;
            string dotsLR = new string('.', dotsLRCount);

            int diesCount = width - (dotsLRCount * 2);
            string dies = new string('#', diesCount);

            int dotsLRSignCount = (width - 10) / 2;
            string dotsLRSign = new string('.', dotsLRSignCount);

            for (int row = 1; row <= n / 2; row++)
            {
                dotsLR = new string('.', dotsLRCount);
                dies = new string('#', diesCount);

                Console.WriteLine($"{dotsLR}{dies}{dotsLR}");

                diesCount -= 2;
                dotsLRCount++;
            }

            int dotsMidCount = width - (dotsLRCount * 2) - 2;
            string dotsMid = new string('.', dotsMidCount);

            for (int i = 1; i <= (n / 2) + 1; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);

                Console.WriteLine($"{dotsLR}#{dotsMid}#{dotsLR}");

                dotsMidCount -= 2;
                dotsLRCount++;
            }

            dotsLRCount--;
            dotsLR = new string('.', dotsLRCount);

            diesCount = width - (dotsLRCount * 2);
            dies = new string('#', diesCount);
      
            Console.WriteLine($"{dotsLR}{dies}{dotsLR}");

            dotsLRCount -= 2;
            diesCount = width - (dotsLRCount * 2);

            for (int i = 1; i <= n / 2; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                dies = new string('#', diesCount);

                Console.WriteLine($"{dotsLR}{dies}{dotsLR}");
            }

            Console.WriteLine($"{dotsLRSign}D^A^N^C^E^{dotsLRSign}");

            for (int i = 1; i <= (n / 2) + 1; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                dies = new string('#', diesCount);

                Console.WriteLine($"{dotsLR}{dies}{dotsLR}");
            }
        }
    }
}