using System;

namespace PB_May_2017_3_School_Camp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string group = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0.0;

            if (season == "winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = students * days * 9.60;
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                    price = students * days * 9.60;
                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    price = students * days * 10.00;
                }
            }
            else if (season == "spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                    price = students * days * 7.20;
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                    price = students * days * 7.20;
                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    price = students * days * 9.50;
                }
            }
            else if (season == "summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                    price = students * days * 15.00;
                }
                else if (group == "boys")
                {
                    sport = "Football";
                    price = students * days * 15.00;
                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    price = students * days * 20.00;
                }
            }

            if (sport == "" || price == 0.0)
            {
                Console.WriteLine("error");
            }
            else if (students >= 50)
            {
                price = price - (price * 0.50);
                Console.WriteLine("{0} {1:F2} lv.", sport, price);
            }
            else if (students >= 20 && students < 50)
            {
                price = price - (price * 0.15);
                Console.WriteLine("{0} {1:F2} lv.", sport, price);
            }
            else if (students >= 10 && students < 20)
            {
                price = price - (price * 0.05);
                Console.WriteLine("{0} {1:F2} lv.", sport, price);
            }
            else
            {
                Console.WriteLine("{0} {1:F2} lv.", sport, price);
            }
        }
    }
}