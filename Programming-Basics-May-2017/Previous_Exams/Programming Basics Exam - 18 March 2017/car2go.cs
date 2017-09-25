using System;

namespace PB_March_1_2017_3_Car_To_Go
{
    class car2go
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double price = 0.00;
            string carClass = "";
            string carType = "";

            if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }
            else if (season == "summer")
            {
                if (budget > 100 && budget <= 500)
                {
                    carClass = "Compact class";
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else if (budget <= 100)
                {
                    carClass = "Economy class";
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
            }
            else if (season == "winter")
            {
                if (budget > 100 && budget <= 500)
                {
                    carClass = "Compact class";
                    carType = "Jeep";
                    price = budget * 0.80;
                }
                else if (budget <= 100)
                {
                    carClass = "Economy class";
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }

            Console.WriteLine("{0}", carClass);
            Console.WriteLine("{0} - {1:f2}", carType, price);
        }
    }
}
