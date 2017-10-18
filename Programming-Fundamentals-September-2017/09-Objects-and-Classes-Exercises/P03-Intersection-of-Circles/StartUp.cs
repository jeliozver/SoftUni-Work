namespace P03_Intersection_of_Circles
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var circleOne = GetCircleInfo();
            var circleTwo = GetCircleInfo();

            Console.WriteLine(IsCirclesIntersect(circleOne, circleTwo)
                ? "Yes"
                : "No");
        }

        public static Circle GetCircleInfo()
        {
            double[] circleProperties = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point circleCenter = new Point
            {
                X = circleProperties[0],
                Y = circleProperties[1]
            };

            Circle circle = new Circle
            {
                Radius = circleProperties[2],
                Center = circleCenter
            };

            return circle;
        }

        public static bool IsCirclesIntersect(Circle cirleOne, Circle circleTwo)
        {
            var circleOneCenter = cirleOne.Center;
            var circleTwoCenter = circleTwo.Center;

            double distance = CalcDistance(circleOneCenter, circleTwoCenter);

            return !(distance > cirleOne.Radius + circleTwo.Radius);
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