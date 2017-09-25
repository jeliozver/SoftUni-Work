using System;

namespace Increasing_4_Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = i + 1; j <= num2; j++)
                {
                    for (int k = j + 1; k <= num2; k++)
                    {
                        for (int l = k + 1; l <= num2; l++)
                        {
                            Console.WriteLine($"{i} {j} {k} {l} ");
                            sum++;
                        }
                    }
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}