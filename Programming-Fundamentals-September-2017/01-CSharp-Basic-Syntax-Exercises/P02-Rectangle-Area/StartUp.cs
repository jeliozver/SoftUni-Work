namespace P02_Rectangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = width * height;

            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
