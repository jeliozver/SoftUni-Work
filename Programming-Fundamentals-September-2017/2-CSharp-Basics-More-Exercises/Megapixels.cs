using System;

namespace Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double megaPixels = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megaPixels, 1)}MP");
        }
    }
}