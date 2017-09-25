using System;

namespace PB_Dec_2016_3_Flowers
{
    class flowers
    {
        static void Main(string[] args)
        {
            int flower1 = int.Parse(Console.ReadLine());
            int flower2 = int.Parse(Console.ReadLine());
            int flower3 = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string isHoliday = Console.ReadLine().ToLower();

            double flower1Price = 0.00;
            double flower2Price = 0.00;
            double flower3Price = 0.00;
            double flowersTotal = 0.00;


            if (season == "spring" || season == "summer")
            {
                flower1Price = 2.00;
                flower2Price = 4.10;
                flower3Price = 2.50;

                if (isHoliday == "y")
                {
                    flower1Price = 2.00 + (2.00 * 0.15);
                    flower2Price = 4.10 + (4.10 * 0.15);
                    flower3Price = 2.50 + (2.50 * 0.15);
                }

                flowersTotal = (flower1 * flower1Price) + (flower2 * flower2Price) + (flower3 * flower3Price);

                if (season == "spring" && flower3 > 7)
                {
                    flowersTotal = flowersTotal - (flowersTotal * 0.05);
                }
                if (flower1 + flower2 + flower3 > 20)
                {
                    flowersTotal = flowersTotal - (flowersTotal * 0.20);
                }
            }
            else if (season == "autumn" || season == "winter")
            {
                flower1Price = 3.75;
                flower2Price = 4.50;
                flower3Price = 4.15;

                if (isHoliday == "y")
                {
                    flower1Price = 3.75 + (3.75 * 0.15);
                    flower2Price = 4.50 + (4.50 * 0.15);
                    flower3Price = 4.15 + (4.15 * 0.15);
                }

                flowersTotal = (flower1 * flower1Price) + (flower2 * flower2Price) + (flower3 * flower3Price);

                if (season == "winter" && flower2 >= 10)
                {
                    flowersTotal = flowersTotal - (flowersTotal * 0.10);
                }
                if (flower1 + flower2 + flower3 > 20)
                {
                    flowersTotal = flowersTotal - (flowersTotal * 0.20);
                }
            }

            Console.WriteLine("{0:f2}", flowersTotal + 2);
        }
    }
}
