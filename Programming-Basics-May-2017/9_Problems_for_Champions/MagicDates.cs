using System;

namespace Magic_Dates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            bool isPrinted = false;
            string formatPrint = "dd-MM-yyyy";

            DateTime currentDate = new DateTime(startYear, 1 , 1);

            while (currentDate.Year <= endYear)
            {
                int d1 = currentDate.Day / 10;
                int d2 = currentDate.Day % 10;

                int d3 = currentDate.Month / 10;
                int d4 = currentDate.Month % 10;

                string currentYear = Convert.ToString(currentDate.Year);
                
                int d5 = currentYear[0] - 48;
                int d6 = currentYear[1] - 48;
                int d7 = currentYear[2] - 48;
                int d8 = currentYear[3] - 48;

                int weight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                             d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                             d3 * (d4 + d5 + d6 + d7 + d8) +
                             d4 * (d5 + d6 + d7 + d8) +
                             d5 * (d6 + d7 + d8) +
                             d6 * (d7 + d8) +
                             d7 * (d8);
                
                if (weight == magicWeight)
                {
                    isPrinted = true;
                    Console.WriteLine(currentDate.ToString(formatPrint));
                }

                currentDate = currentDate.AddDays(1);
            }

            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}
