using System;

namespace Greatest_Common_Divisor
{
    class greatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            while (num2 != 0)
            {
                int oldNum2 = num2;
                num2 = num1 % num2;
                num1 = oldNum2;
            }
            Console.WriteLine(num1);
        }
    }
}
