namespace P04_Tourist_Information
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string imperialUnit = Console.ReadLine().ToLower();
            double valueToConvert = double.Parse(Console.ReadLine());

            double valueConverted = 0;

            switch (imperialUnit)
            {
                case "miles":
                    valueConverted = valueToConvert * 1.6;
                    Console.WriteLine($"{valueToConvert} {imperialUnit} = {valueConverted:f2} kilometers");
                    break;
                case "inches":
                    valueConverted = valueToConvert * 2.54;
                    Console.WriteLine($"{valueToConvert} {imperialUnit} = {valueConverted:f2} centimeters");
                    break;
                case "feet":
                    valueConverted = valueToConvert * 30;
                    Console.WriteLine($"{valueToConvert} {imperialUnit} = {valueConverted:f2} centimeters");
                    break;
                case "yards":
                    valueConverted = valueToConvert * 0.91;
                    Console.WriteLine($"{valueToConvert} {imperialUnit} = {valueConverted:f2} meters");
                    break;
                case "gallons":
                    valueConverted = valueToConvert * 3.8;
                    Console.WriteLine($"{valueToConvert} {imperialUnit} = {valueConverted:f2} liters");
                    break;
            }
        }
    }
}