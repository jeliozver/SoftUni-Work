using System;

namespace PB_Dec_2016_2_Change_Tiles
{
    class changeTiles
    {
        static void Main(string[] args)
        {
            double moneyAvb = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorHeigh = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeigh = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workmanPrice = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorHeigh;
            double tileArea = (tileSide * tileHeigh) / 2;
            double tilesReq = Math.Ceiling(floorArea / tileArea) + 5;
            double changePrice = (tilePrice * tilesReq) + workmanPrice;

            if (moneyAvb >= changePrice)
            {
                Console.WriteLine("{0:F2} lv left.", moneyAvb - changePrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", changePrice - moneyAvb);
            }
        }
    }
}
