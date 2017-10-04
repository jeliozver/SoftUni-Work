namespace P05_Temperature_Conversion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{FahrenheitToCelsius(fahrenheit):f2}");
        }

        private static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}