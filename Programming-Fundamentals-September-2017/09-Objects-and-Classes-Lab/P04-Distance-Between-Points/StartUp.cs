namespace P04_Distance_Between_Points
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] inputOne = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point firstPoint = new Point
            {
                X = inputOne[0],
                Y = inputOne[1]
            };

            double[] inputTwo = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point secondPoint = new Point
            {
                X = inputTwo[0],
                Y = inputTwo[1]
            };

            double result = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = firstPoint.X - secondPoint.X;
            double diffY = firstPoint.Y - secondPoint.Y;

            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            double distance = Math.Sqrt(powX + powY);

            return distance;
        }
    }
}