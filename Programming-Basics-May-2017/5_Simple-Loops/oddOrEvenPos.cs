using System;

namespace Odd_or_Even_Position
{
    class oddOrEvenPos
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0.0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            double oddSum = 0.0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    evenMax = Math.Max(evenMax, num);
                    evenMin = Math.Min(evenMin, num);
                }
                else
                {
                    oddSum += num;
                    oddMax = Math.Max(oddMax, num);
                    oddMin = Math.Min(oddMin, num);
                }
            }

            bool isEvenChanged = evenMax == double.MinValue || evenMin == double.MaxValue;
            bool isOddChanged = oddMax == double.MinValue || oddMin == double.MaxValue;

            Console.WriteLine("OddSum={0},", oddSum);

            if (isOddChanged)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
            }

            Console.WriteLine("EvenSum={0},", evenSum);

            if (isEvenChanged)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}
