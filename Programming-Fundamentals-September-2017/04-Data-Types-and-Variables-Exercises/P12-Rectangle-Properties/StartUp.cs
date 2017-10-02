namespace P12_Rectangle_Properties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (height + width);
            double area = height * width;
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height,2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}