namespace P01_Debit_Card_Number
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDigit:d4} {secondDigit:d4} {thirdDigit:d4} {fourthDigit:d4}");
        }
    }
}
