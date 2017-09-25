using System;

namespace PB_June_2017_3_Fruit_Coctails
{
    class FruitCoctails
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string coctailSize = Console.ReadLine();
            int coctailsCount = int.Parse(Console.ReadLine());

            double price = 0;

            if (fruit == "Watermelon")
            {
                if (coctailSize == "big")
                {
                    price = (5 * 28.70) * coctailsCount;
                }
                else
                {
                    price = (2 * 56.00) * coctailsCount;
                }
            }
            else if (fruit == "Mango")
            {
                if (coctailSize == "big")
                {
                    price = (5 * 19.60) * coctailsCount;
                }
                else
                {
                    price = (2 * 36.66) * coctailsCount;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (coctailSize == "big")
                {
                    price = (5 * 24.80) * coctailsCount;
                }
                else
                {
                    price = (2 * 42.10) * coctailsCount;
                }
            }
            else
            {
                if (coctailSize == "big")
                {
                    price = (5 * 15.20) * coctailsCount;
                }
                else
                {
                    price = (2 * 20.00) * coctailsCount;
                }
            }

            if (price > 1000)
            {
                price /= 2;
            }
            else if (price >= 400 && price <= 1000)
            {
                price -= price * 0.15;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}