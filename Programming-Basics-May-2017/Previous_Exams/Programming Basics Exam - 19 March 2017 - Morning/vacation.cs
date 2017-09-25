using System;

namespace PB_MarchM_2_2017_3_Vacation
{
    class vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double price = 0.00;
            string location = "";
            string place = "";

            if (budget > 3000)
            {
                place = "Hotel";
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else if (budget <= 1000)
            {
                place = "Camp";
                if (season == "summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", location, place, price);
        }
    }
}
