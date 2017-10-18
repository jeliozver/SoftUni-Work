namespace P07_Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfSales; i++)
            {
                var currentSale = GetSaleInfo();

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0m;
                }

                salesByTown[currentSale.Town] += currentSale.SaleResult;
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        public static Sale GetSaleInfo()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var sale = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };

            return sale;
        }
    }
}