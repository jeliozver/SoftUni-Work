using System;

namespace Num_in_Range_1_to_100
{
    class numInRange1To100
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
