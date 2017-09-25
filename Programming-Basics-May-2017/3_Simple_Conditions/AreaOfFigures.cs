using System;

namespace Area_of_Figures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = (Console.ReadLine().ToLower());

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double squareArea = a * a;
                Console.WriteLine(squareArea);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double rectangleArea = a * h;
                Console.WriteLine(rectangleArea);
            }
            else if (figure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * circleRadius * circleRadius;
                Console.WriteLine("{0:F3}", circleArea);
            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (a * h) / 2;
                Console.WriteLine(triangleArea);
            }
        }
    }
}
