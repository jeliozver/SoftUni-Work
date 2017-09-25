using System;

namespace Sums_3_Numbers
{
    class Sums3Numbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum1 = num1 + num2;
            int sum2 = num1 + num3;
            int sum3 = num2 + num3;

            if (num1 + num2 == num3)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num2} + {num1} = {sum1}");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {sum1}");
                }
            }
            else if (num1 + num3 == num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num3} + {num1} = {sum2}");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num3} = {sum2}");
                }
            }
            else if (num2 + num3 == num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num3} + {num2} = {sum3}");
                }
                else
                {
                    Console.WriteLine($"{num2} + {num3} = {sum3}");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
