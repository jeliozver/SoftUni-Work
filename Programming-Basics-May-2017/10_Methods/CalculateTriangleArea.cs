using System;

namespace Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a, h);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double a, double h)
        {
            return (a * h) / 2;
        }
    }
}