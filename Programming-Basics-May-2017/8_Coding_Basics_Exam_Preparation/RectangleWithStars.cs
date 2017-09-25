using System;

namespace Rectangle_With_Stars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 2;
            int midRowsHeight = 0;
            if (n % 2 == 0)
            {
                midRowsHeight = n - 1;
            }
            else
            {
                midRowsHeight = n;
            }

            // First Row
            Console.WriteLine(new string('%', width));

            // Mid Rows
            string space = new string(' ', width - 2);
            for (int midRow = 1; midRow <= midRowsHeight; midRow++)
            {
                if (midRow == (midRowsHeight + 1) / 2)
                {
                    space = new string(' ', (width - 4) / 2);
                    Console.WriteLine($"%{space}**{space}%");
                }
                else
                {
                    space = new string(' ', width - 2);
                    Console.WriteLine($"%{space}%");
                }
            }

            // Last Row
            Console.WriteLine(new string('%', width));
        }
    }
}
