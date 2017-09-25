using System;

namespace Half_Sum_Element
{
    class halfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int largestNum = int.Parse(Console.ReadLine());

            int numsSum = largestNum;

            for (int i = 0; i < n - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numsSum += num;
                if (num > largestNum)
                {
                    largestNum = num;
                }
            }

            int diff = Math.Abs(largestNum - numsSum);

            if (largestNum + largestNum == numsSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", largestNum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(largestNum - diff));
            }
        }
    }
}
