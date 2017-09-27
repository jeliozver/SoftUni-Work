namespace P03_Megapixels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double megaPixels = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megaPixels, 1)}MP");
        }
    }
}
