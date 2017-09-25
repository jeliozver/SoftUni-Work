using System;

namespace PB_May_2017_6_Number_Generator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int firstDigit = m; firstDigit >= 1; firstDigit--)
            {
                for (int secondDigit = n; secondDigit >= 1; secondDigit--)
                {
                    for (int ThirdDigit = l; ThirdDigit >= 1; ThirdDigit--)
                    {
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }

                        string mergeString = $"{firstDigit}{secondDigit}{ThirdDigit}";
                        int mergeInt = Int32.Parse(mergeString);

                        if (mergeInt % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (ThirdDigit == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (mergeInt % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                    }
                }
            }

            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }
    }
}