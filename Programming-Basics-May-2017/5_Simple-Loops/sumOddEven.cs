using System;

namespace Odd_Even_Sum
{
    class sumOddEven
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int numPos = 1; numPos <= n; numPos++)
            {
                int num = int.Parse(Console.ReadLine());
                if (numPos % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
