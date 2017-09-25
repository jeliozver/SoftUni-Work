using System;

namespace Miles_to_Kilometers
{
    class Miles2Kilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double convertToKilometers = miles * 1.60934;

            Console.WriteLine($"{convertToKilometers:f2}");
        }
    }
}