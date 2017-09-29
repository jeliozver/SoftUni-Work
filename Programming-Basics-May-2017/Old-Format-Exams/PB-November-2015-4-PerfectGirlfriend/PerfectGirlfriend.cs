using System;

namespace PB_November_2015_4_PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            string currentDate = Console.ReadLine();
            int perfectGirls = 0;

            while (currentDate != "Enough dates!")
            {
                string currentDateSeparate = currentDate.Replace('\\', ' ');
                string[] parameters = currentDateSeparate.Split();
                string DayOfWeek = parameters[0];
                string telephone = parameters[1];
                string braSize = parameters[2];
                string girlName = parameters[3];

                int sum = 0;

                // Day of Week calculations
                switch (DayOfWeek)
                {
                    case "Monday": sum += 1; break;
                    case "Tuesday": sum += 2; break;
                    case "Wednesday": sum += 3; break;
                    case "Thursday": sum += 4; break;
                    case "Friday": sum += 5; break;
                    case "Saturday": sum += 6; break;
                    case "Sunday": sum += 7; break;
                }

                // Telephone number calculations
                for (int i = 0; i < telephone.Length; i++)
                {
                    sum += telephone[i] - 48;
                }

                // Bra size calculations
                string braSizeDigit = string.Empty;
                char braSizeLetter = ' ';

                if (braSize.Length > 3)
                {
                    braSizeDigit += "" + braSize[0] + braSize[1] + braSize[2];
                    braSizeLetter = braSize[3];
                }
                else
                {
                    braSizeDigit += "" + braSize[0] + braSize[1];
                    braSizeLetter = braSize[2];
                }

                sum += Convert.ToInt32(braSizeDigit) * Convert.ToInt32(braSizeLetter);

                // Girl name calculations
                sum -= girlName[0] * girlName.Length;

                if (sum >= 6000)
                {
                    Console.WriteLine($"{girlName} is perfect for you.");
                    perfectGirls++;
                }
                else
                {
                    Console.WriteLine($"Keep searching, {girlName} is not for you.");
                }

                currentDate = Console.ReadLine();
            }

            Console.WriteLine(perfectGirls);
        }
    }
}