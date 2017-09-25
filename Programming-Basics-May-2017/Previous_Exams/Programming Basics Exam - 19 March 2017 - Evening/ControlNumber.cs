using System;

namespace PB_MarchE_2_2017_6_Control_Number
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int moves = 0;
            int sum = 0;

            for (int firstDigit = 1; firstDigit <= n; firstDigit++)
            {
                for (int secondDigit = m; secondDigit >= 1; secondDigit--)
                {
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                    sum += (firstDigit * 2) + (secondDigit * 3);
                    moves++;
                }
            }

            Console.WriteLine($"{moves} moves");
        }
    }
}