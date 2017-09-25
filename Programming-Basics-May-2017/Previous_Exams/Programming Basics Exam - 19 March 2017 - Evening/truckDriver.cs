using System;

namespace PB_MarchE_2_2017_3_Truck_Driver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double monthPayment = 0.00;
            double seasonPayment = 0.00;

            if (season == "spring" || season == "autumn")
            {
                if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    monthPayment = kmPerMonth * 1.45;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    monthPayment = kmPerMonth * 0.95;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (5000 >= kmPerMonth)
                {
                    monthPayment = kmPerMonth * 0.75;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
            }
            else if (season == "summer")
            {
                if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    monthPayment = kmPerMonth * 1.45;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    monthPayment = kmPerMonth * 1.10;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (5000 >= kmPerMonth)
                {
                    monthPayment = kmPerMonth * 0.90;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }

            }
            else if (season == "winter")
            {
                if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                {
                    monthPayment = kmPerMonth * 1.45;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    monthPayment = kmPerMonth * 1.25;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
                else if (5000 >= kmPerMonth)
                {
                    monthPayment = kmPerMonth * 1.05;
                    seasonPayment = (4 * monthPayment) - ((4 * monthPayment) * 0.10);
                }
            }
                Console.WriteLine($"{seasonPayment:f2}");
        }
    }
}