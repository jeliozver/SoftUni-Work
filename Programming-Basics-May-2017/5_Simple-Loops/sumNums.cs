using System;

namespace Sum_Numbers
{
    class sumNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of n numbers");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Number {0} = ", i);
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
