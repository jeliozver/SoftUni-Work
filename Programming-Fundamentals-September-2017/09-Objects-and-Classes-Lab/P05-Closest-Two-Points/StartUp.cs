namespace P05_Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPoints = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            var distances = new SortedList<double, double[]>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                double[] currentPoint = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]
                });
            }

            distances = CollectPointsDistances(points);

            foreach (var distance in distances)
            {
                if (distance.Key.Equals(distances.Keys.Min()))
                {
                    Console.WriteLine($"{distance.Key:f3}");
                    Console.WriteLine($"({distance.Value[0]}, {distance.Value[1]})");
                    Console.WriteLine($"({distance.Value[2]}, {distance.Value[3]})");
                    break;
                }
            }
        }

        public static SortedList<double, double[]> CollectPointsDistances(List<Point> points)
        {
            var distances = new SortedList<double, double[]>();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    Point firstPoint = new Point
                    {
                        X = points[i].X,
                        Y = points[i].Y
                    };

                    Point secondPoint = new Point
                    {
                        X = points[j].X,
                        Y = points[j].Y
                    };

                    double currentDistance = CalcDistance(firstPoint, secondPoint);

                    if (!distances.ContainsKey(currentDistance))
                    {
                        distances[currentDistance] = new[] { firstPoint.X, firstPoint.Y, secondPoint.X, secondPoint.Y };
                    }
                }
            }

            return distances;
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