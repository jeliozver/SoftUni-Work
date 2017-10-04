namespace P08_Center_Point
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetClosestPointToTheCenter(x1, y1, x2, y2));
        }

        private static string GetClosestPointToTheCenter(double x1, double y1, double x2, double y2)
        {
            string closestPoint = String.Empty;
            double pointOneDistance = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
            double pointTwoDistance = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));

            closestPoint = pointOneDistance <= pointTwoDistance 
                ? $"({x1}, {y1})" 
                : $"({x2}, {y2})";

            return closestPoint;
        }
    }
}