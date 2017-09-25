using System;

namespace Metric_Converter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string input = (Console.ReadLine().ToLower());
            string output = (Console.ReadLine().ToLower());

            if (input == "mm")
            {
                amount = amount / 1000;
            }
            else if (input == "cm")
            {
                amount = amount / 100;
            }
            else if (input == "mi")
            {
                amount = amount / 0.000621371192m;
            }
            else if (input == "in")
            {
                amount = amount / 39.3700787m;
            }
            else if (input == "km")
            {
                amount = amount / 0.001m;
            }
            else if (input == "ft")
            {
                amount = amount / 3.2808399m;
            }
            else if (input == "yd")
            {
                amount = amount / 1.0936133m;
            }


            if (output == "mm")
            {
                amount = amount * 1000;
            }
            else if (output == "cm")
            {
                amount = amount * 100;
            }
            else if (output == "mi")
            {
                amount = amount * 0.000621371192m;
            }
            else if (output == "in")
            {
                amount = amount * 39.3700787m;
            }
            else if (output == "km")
            {
                amount = amount * 0.001m;
            }
            else if (output == "ft")
            {
                amount = amount * 3.2808399m;
            }
            else if (output == "yd")
            {
                amount = amount * 1.0936133m;
            }

            Console.WriteLine("{0:F8} {1} ", amount, output);
        }
    }
}
