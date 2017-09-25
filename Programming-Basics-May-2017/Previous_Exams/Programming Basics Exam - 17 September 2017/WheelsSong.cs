using System;

namespace PB_Sep_2_2017_6_The_Song_of_the_Wheels
{
    class WheelsSong
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int combinations = 0;
            bool isPasswordFound = false;
            string password = string.Empty;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (b > a && c > d && a * b + c * d == controlNum)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                combinations++;

                                if (combinations == 4)
                                {
                                    isPasswordFound = true;
                                    password = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }

            if (isPasswordFound)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {password}");
            }
            else if (combinations > 0 && combinations < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}