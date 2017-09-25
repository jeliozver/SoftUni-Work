using System;

namespace PB_Sep_2017_6_Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int oneLevaCount = int.Parse(Console.ReadLine());
            int twoLevaCount = int.Parse(Console.ReadLine());
            int fiveLevaCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLevaCount; i++)
            {
                for (int j = 0; j <= twoLevaCount; j++)
                {
                    for (int k = 0; k <= fiveLevaCount; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}