using System;

namespace Inches_to_Centimeters
{
    class Inch2Cen
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
