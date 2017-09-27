namespace P03_Miles_to_Kilometers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            double convertToKilometers = miles * 1.60934;

            Console.WriteLine($"{convertToKilometers:f2}");
        }
    }
}
