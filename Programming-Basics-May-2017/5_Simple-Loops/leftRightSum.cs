using System;

namespace Left_and_Right_Sum
{
    class leftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lefttSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int leftSide = int.Parse(Console.ReadLine());
                lefttSum += leftSide;
            }

            for (int i = 0; i < n; i++)
            {
                int rightSide = int.Parse(Console.ReadLine());
                rightSum += rightSide;
            }

            if (lefttSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", lefttSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(lefttSum - rightSum));
            }
        }
    }
}
