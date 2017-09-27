namespace P12_Number_Checker
{
    using System;

    public class StartUp
    {
        public static void Main()
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
