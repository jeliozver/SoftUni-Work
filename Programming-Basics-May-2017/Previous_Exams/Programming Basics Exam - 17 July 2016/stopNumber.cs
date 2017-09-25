using System;

namespace PB_July_2016_6_Stop_Number
{
    class stopNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (i % 2 == 0 && i % 3 == 0 && i == stopNum)
                    {
                        break;
                    }
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                if (i % 2 == 0 && i % 3 == 0 && i == stopNum)
                {
                    break;
                }
            }
        }
    }
}