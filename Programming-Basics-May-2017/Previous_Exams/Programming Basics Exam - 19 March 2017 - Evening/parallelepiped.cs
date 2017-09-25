using System;

namespace PB_MarchE_2_2017_5_Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = (4 * n) + 4;
            int width = (3 * n) + 1;

            string waves = new string('~', n - 2);

            int dotsLeftTopCount = 0;
            string dotsLeftTop = new string('.', dotsLeftTopCount);
            int dotsRightTopCount = (width - 2) - (n - 2);
            string dotsRightTop = new string('.', dotsRightTopCount);

            int dotsLeftBottomCount = 0;
            string dotsLeftBottom = new string('.', dotsLeftBottomCount);
            int dotsRightBottomCount = (width - dotsLeftBottomCount) - (n - 2) - 3;
            string dotsRightBottom = new string('.', dotsRightBottomCount);

            // First row
            Console.WriteLine($"+{waves}+{dotsRightTop}");
            // Top part rows
            dotsRightTopCount--;
            for (int i = 1; i <= height / 2 - 1; i++)
            {
                dotsLeftTop = new string('.', dotsLeftTopCount);
                dotsRightTop = new string('.', dotsRightTopCount);

                Console.WriteLine($"|{dotsLeftTop}\\{waves}\\{dotsRightTop}");

                dotsLeftTopCount++;
                dotsRightTopCount--;
            }

            // Bottom rows
            for (int i = 1; i <= height / 2 - 1; i++)
            {
                dotsLeftBottom = new string('.', dotsLeftBottomCount);
                dotsRightBottom = new string('.', dotsRightBottomCount);

                Console.WriteLine($"{dotsLeftBottom}\\{dotsRightBottom}|{waves}|");

                dotsLeftBottomCount++;
                dotsRightBottomCount--;
            }

            // Last row
            dotsLeftBottom = new string('.', dotsLeftBottomCount);
            Console.WriteLine($"{dotsLeftBottom}+{waves}+");
        }
    }
}