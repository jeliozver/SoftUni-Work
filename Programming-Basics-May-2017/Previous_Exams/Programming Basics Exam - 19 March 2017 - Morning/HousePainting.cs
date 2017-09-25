using System;

namespace PB_MarchM_2_2017_1_House_Painting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWalls = (x * y) * 2;
            double windowsArea = (1.5 * 1.5) * 2;
            double sideWallsPaintArea = sideWalls - windowsArea;
            double backWall = x * x;
            double frontWall = x * x;
            double door = 1.2 * 2;
            double frontBackWallsPaintArea = (frontWall + backWall) - door;
            double totalWallsPaintArea = sideWallsPaintArea + frontBackWallsPaintArea;
            double greenPaintLiters = totalWallsPaintArea / 3.4;

            double roofRectangles = 2 * (x * y);
            double roofTriangles = 2 * (x * h / 2);
            double totalRoofPaintArea = roofRectangles + roofTriangles;
            double redPaintLiters = totalRoofPaintArea / 4.3;

            Console.WriteLine("{0:F2}", greenPaintLiters);
            Console.WriteLine("{0:F2}", redPaintLiters);
        }
    }
}
