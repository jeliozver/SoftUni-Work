using System;

namespace Diamond
{
    class diamond
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;

            for (int i = 0; i <= (n - 1) / 2; i++)
            {

                var mid = n - (2 * leftRight) - 2;
                string hyphen = new string('-', leftRight);

                if (mid >= 0)
                {
                    string hyphenMid = new string('-', mid);
                    Console.WriteLine($"{hyphen}*{hyphenMid}*{hyphen}");
                }
                else
                {
                    Console.WriteLine($"{hyphen}*{hyphen}");
                }

                leftRight--;
            }

            leftRight = 1;

            for (int i = 1; i <= (n - 1) / 2; i++)
            {

                var mid = n - (2 * leftRight) - 2;
                string hyphen = new string('-', leftRight);

                if (mid >= 0)
                {
                    string hyphenMid = new string('-', mid);
                    Console.WriteLine($"{hyphen}*{hyphenMid}*{hyphen}");
                }
                else
                {
                    Console.WriteLine($"{hyphen}*{hyphen}");
                }

                leftRight++;
            }
        }
    }
}