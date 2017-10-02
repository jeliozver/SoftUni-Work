namespace P02_Number_Checker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string inputNumber = Console.ReadLine();

            try
            {
                long.Parse(inputNumber);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}