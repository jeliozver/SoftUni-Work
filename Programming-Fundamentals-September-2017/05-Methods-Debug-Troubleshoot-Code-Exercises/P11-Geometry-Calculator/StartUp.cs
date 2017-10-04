namespace P11_Geometry_Calculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{CalcTriangleArea(side, height):f2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{CalcSquareArea(side):f2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{CalcRectangleArea(width, height):f2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"{CalcCircleArea(radius):f2}");
            }
        }

        private static double CalcTriangleArea(double side, double height)
        {
            double triangleArea = side * height / 2;
            return triangleArea;
        }

        private static double CalcSquareArea(double side)
        {
            double squareArea = Math.Pow(side, 2);
            return squareArea;
        }

        private static double CalcRectangleArea(double width, double height)
        {
            double rectangleArea = width * height;
            return rectangleArea;
        }

        private static double CalcCircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
    }
}