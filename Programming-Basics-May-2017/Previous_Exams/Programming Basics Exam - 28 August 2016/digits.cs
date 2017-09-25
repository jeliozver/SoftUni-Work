using System;

namespace PB_Aug_2016_6_Digits
{
    class digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // Convert to string and break it into digits
            // using each digit's code in ASCII Table
            string numStr = Convert.ToString(num);
            int d1 = numStr[0] - 48;
            int d2 = numStr[1] - 48;
            int d3 = numStr[2] - 48;

            for (int row = 0; row < d1 + d2; row++)
            {
                for (int col = 0; col < d1 + d3; col++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                    }
                    else
                    {
                        num += d3;
                    }
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}