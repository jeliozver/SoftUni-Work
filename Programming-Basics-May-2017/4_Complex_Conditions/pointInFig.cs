using System;

namespace Point_in_the_Figure
{
    class pointInFig
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool onLeftSide = (x == 0) && (y >= 0) && (y <= h);
            bool onRightSide = (x == 3 * h) && (y >= 0) && (y <= h);
            bool onUpSide = (y == h) && ((x >= 0 && x <= h) || (x >= 2 * h && x <= 3 * h));
            bool onDownSide = (y == 0) && (x >= 0) && (x <= 3 * h);

            bool onLeftSideTop = (x == h) && (y >= h) && (y <= 4 * h);
            bool onRightSideTop = (x == 2 * h) && (y >= h) && (y <= 4 * h);
            bool onTopSide = (y == 4 * h) && (x >= h) && (x <= 2 * h);

            bool isInside = (x > 0 && x < 3 * h && y > 0 && y < h) || (x > h && x < 2 * h && y > 0 && y < 4 * h);

            if (isInside)
            {
                Console.WriteLine("inside");
            }
            else if (onLeftSide || onLeftSideTop || onRightSide || onRightSideTop || onUpSide || onDownSide || onTopSide)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
