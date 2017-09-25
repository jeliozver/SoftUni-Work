using System;

namespace Generate_Rectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int generatedRectangles = 0;
            int area = 0;

            for (int i = -n; i < n; i++)
            {
                for (int j = -n; j < n; j++)
                {
                    for (int k = i + 1; k <= n; k++)
                    {
                        for (int l = j + 1; l <= n; l++)
                        {
                            area = Math.Abs(k - i) * Math.Abs(l - j);
                            if (area >= m)
                            {
                                Console.WriteLine($"({i}, {j}) ({k}, {l}) -> {area}");
                                generatedRectangles++;
                            }
                        }
                    }
                }
            }
            if (generatedRectangles == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}