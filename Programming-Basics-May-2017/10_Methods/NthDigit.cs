using System;

namespace Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(num, index));
        }

        static int FindNthDigit(int number, int index)
        {
            int lastNDigit = 0;
            for (int i = 0; i < index; i++)
            {
                lastNDigit = number % 10;
                number = number / 10;
            }

            return lastNDigit;
        }
    }
}