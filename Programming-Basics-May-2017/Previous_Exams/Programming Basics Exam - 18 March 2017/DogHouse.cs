using System;

namespace PB_March_1_2017_1_Dog_House
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sideWalls = a * (a / 2) * 2;
            double backWall = (a / 2) * (a / 2) + (a / 2 * (b - a / 2)) / 2;
            double entrance = (a / 5) * (a / 5);
            double frontWall = backWall - entrance;
            double wallsTotalArea = sideWalls + backWall + frontWall;
            double greenPaintLiters = wallsTotalArea / 3;

            double roofArea = a * (a / 2) * 2;
            double redPaintLiters = roofArea / 5;

            Console.WriteLine("{0:F2}", greenPaintLiters);
            Console.WriteLine("{0:F2}", redPaintLiters);
        }
    }
}
