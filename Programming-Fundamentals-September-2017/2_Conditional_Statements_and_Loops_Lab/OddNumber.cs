using System;

namespace Odd_Number
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int number = int.Parse(Console.ReadLine());

                if (Math.Abs(number) % 2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}