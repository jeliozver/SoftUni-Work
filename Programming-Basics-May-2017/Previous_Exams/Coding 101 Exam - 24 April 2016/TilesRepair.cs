using System;

namespace PB_April_2016_1_Tiles_Repair
{
    class TilesRepair
    {
        static void Main(string[] args)
        {
            var playgroundLenght = int.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileHeight = double.Parse(Console.ReadLine());
            var benchWidth = int.Parse(Console.ReadLine());
            var benchHeight = int.Parse(Console.ReadLine());

            var coverArea = (playgroundLenght * playgroundLenght) - (benchWidth * benchHeight);
            var tilesArea = tileWidth * tileHeight;
            var tilesAmount = coverArea / tilesArea;
            var timeAmount = tilesAmount * 0.2;

            Console.WriteLine($"{tilesAmount:f2}");
            Console.WriteLine($"{timeAmount:f2}");
        }
    }
}
