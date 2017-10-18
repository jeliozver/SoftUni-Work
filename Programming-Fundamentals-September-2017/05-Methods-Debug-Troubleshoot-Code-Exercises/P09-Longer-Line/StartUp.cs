namespace P09_Longer_Line
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double x1PairOne = double.Parse(Console.ReadLine());
            double y1PairOne = double.Parse(Console.ReadLine());
            double x2PairOne = double.Parse(Console.ReadLine());
            double y2PairOne = double.Parse(Console.ReadLine());
            double x1PairTwo = double.Parse(Console.ReadLine());
            double y1PairTwo = double.Parse(Console.ReadLine());
            double x2PairTwo = double.Parse(Console.ReadLine());
            double y2PairTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(GetLongerLine(x1PairOne, y1PairOne, x2PairOne, y2PairOne,
                                            x1PairTwo, y1PairTwo, x2PairTwo, y2PairTwo));
        }

        public static string GetClosestPointToTheCenter(double x1, double y1, double x2, double y2)
        {
            string closestPoint = String.Empty;
            double pointOneDistance = Math.Sqrt(Math.Pow((0 - x1), 2) + Math.Pow((0 - y1), 2));
            double pointTwoDistance = Math.Sqrt(Math.Pow((0 - x2), 2) + Math.Pow((0 - y2), 2));

            closestPoint = pointOneDistance <= pointTwoDistance
                ? $"({x1}, {y1})({x2}, {y2})"
                : $"({x2}, {y2})({x1}, {y1})";

            return closestPoint;
        }

        public static double CalculateLineLenght(double x1, double y1, double x2, double y2)
        {
            double lineLenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLenght;
        }

        public static string GetLongerLine(double x1PairOne, double y1PairOne,
                                            double x2PairOne, double y2PairOne,
                                            double x1PairTwo, double y1PairTwo,
                                            double x2PairTwo, double y2PairTwo)
        {
            string longerLine = string.Empty;

            double lineOneLenght = CalculateLineLenght(x1PairOne, y1PairOne, x2PairOne, y2PairOne);
            double lineTwoLenght = CalculateLineLenght(x1PairTwo, y1PairTwo, x2PairTwo, y2PairTwo);

            longerLine = lineOneLenght >= lineTwoLenght
                ? GetClosestPointToTheCenter(x1PairOne, y1PairOne, x2PairOne, y2PairOne)
                : GetClosestPointToTheCenter(x1PairTwo, y1PairTwo, x2PairTwo, y2PairTwo);

            return longerLine;
        }
    }
}