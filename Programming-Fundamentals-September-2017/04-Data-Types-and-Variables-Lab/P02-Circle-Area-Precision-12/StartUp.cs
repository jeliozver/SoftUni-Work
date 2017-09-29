namespace P02_Circle_Area_Precision_12
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
