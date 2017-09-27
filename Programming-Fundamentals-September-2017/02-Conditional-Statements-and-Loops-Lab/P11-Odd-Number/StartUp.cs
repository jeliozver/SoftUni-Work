namespace P11_Odd_Number
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
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