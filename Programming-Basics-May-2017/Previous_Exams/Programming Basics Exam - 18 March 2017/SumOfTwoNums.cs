using System;

namespace PB_March_1_2017_6_Sum_of_Two_Nums
{
    class SumOfTwoNums
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinaitons = 0;
            int num1 = 0;
            int num2 = 0;

            for (num1 = startNum; num1 <= endNum; num1++)
            {
                for (num2 = startNum; num2 <= endNum; num2++)
                {
                    combinaitons++;

                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinaitons} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinaitons} combinations - neither equals {magicNum}");
        }
    }
}
