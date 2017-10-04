namespace P06_Calculate_Triangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
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