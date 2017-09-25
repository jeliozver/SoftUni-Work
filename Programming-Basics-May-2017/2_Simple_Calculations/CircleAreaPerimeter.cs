using System;

namespace Circle_Area_Perimeter
{
    class CircleAreaPerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + Math.PI * r * r);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}
