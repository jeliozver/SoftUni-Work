using System;

namespace Number_Checker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}