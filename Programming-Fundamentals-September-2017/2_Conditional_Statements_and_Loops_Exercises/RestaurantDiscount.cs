using System;

namespace Restaurant_Discount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            decimal groupSize = decimal.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = string.Empty;
            decimal hallPrice = 0.00m;
            decimal packagePrice = 0.00m;
            decimal discount = 0.00m;

            decimal totalPrice = 0.00m;
            decimal totalPriceDiscounted = 0.00m;
            decimal pricePerPerson = 0.00m;

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 0.05m;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 0.10m;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 0.15m;
            }

            totalPrice = hallPrice + packagePrice;
            totalPriceDiscounted = totalPrice - (totalPrice * discount);
            pricePerPerson = totalPriceDiscounted / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}