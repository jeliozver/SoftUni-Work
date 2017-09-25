using System;

namespace Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDigit:d4} {secondDigit:d4} {thirdDigit:d4} {fourthDigit:d4}");
        }
    }
}