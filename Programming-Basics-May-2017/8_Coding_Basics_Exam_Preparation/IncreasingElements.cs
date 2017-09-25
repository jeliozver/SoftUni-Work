using System;

namespace Increasing_Elements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentLongestChain = 0;
            int longestChain = 0;
            int lastNum = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > lastNum)
                {
                    currentLongestChain++;
                }
                else
                {
                    currentLongestChain = 1;
                }
                if (currentLongestChain > longestChain)
                {
                    longestChain = currentLongestChain;
                }
                lastNum = num;
            }

            Console.WriteLine(longestChain);
        }
    }
}
