using System;

namespace Point_on_Rectangle_Border
{
    class pointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            bool onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            bool onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            bool onDownSide = (y == y2) && (x >= x1) && (x <= x2);

            if (onLeftSide || onRightSide || onUpSide || onDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
