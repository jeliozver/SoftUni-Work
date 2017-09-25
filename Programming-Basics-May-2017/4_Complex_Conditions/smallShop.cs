using System;

namespace Small_Shop
{
    class smallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = amount * 0.50;
                }
                else if (product == "water")
                {
                    price = amount * 0.80;
                }
                else if (product == "beer")
                {
                    price = amount * 1.20;
                }
                else if (product == "sweets")
                {
                    price = amount * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = amount * 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = amount * 0.40;
                }
                else if (product == "water")
                {
                    price = amount * 0.70;
                }
                else if (product == "beer")
                {
                    price = amount * 1.15;
                }
                else if (product == "sweets")
                {
                    price = amount * 1.30;
                }
                else if (product == "peanuts")
                {
                    price = amount * 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = amount * 0.45;
                }
                else if (product == "water")
                {
                    price = amount * 0.70;
                }
                else if (product == "beer")
                {
                    price = amount * 1.10;
                }
                else if (product == "sweets")
                {
                    price = amount * 1.35;
                }
                else if (product == "peanuts")
                {
                    price = amount * 1.55;
                }
            }

            Console.WriteLine(price);
        }
    }
}