using System;

namespace Equal_Pairs
{
    class equalPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double previousPairSum = 0;
            double currentPairSum = 0;
            double diff = 0;
            double largestDiff = 0;

            for (int i = 0; i < n; i++)
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPairSum = firstNum + secondNum;
                }
                else
                {
                    currentPairSum = firstNum + secondNum;
                    diff = Math.Abs(currentPairSum - previousPairSum);
                    if (diff > largestDiff)
                    {
                        largestDiff = diff;
                    }
                    previousPairSum = currentPairSum;
                }
            }

            if (largestDiff == 0)
            {
                Console.WriteLine("Yes, value ={0}", previousPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}", largestDiff);
            }
        }
    }
}
