namespace P04_Supermarket_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var stocksDatabase = new Dictionary<string, decimal[]>();
            decimal grandTotal = 0;

            string stockInfo = Console.ReadLine();

            while (stockInfo != "stocked")
            {
                string[] arguments = stockInfo.Split(' ').ToArray();

                string stockName = arguments[0];
                decimal itemPrice = decimal.Parse(arguments[1]);
                int itemQuantity = int.Parse(arguments[2]);

                if (!stocksDatabase.ContainsKey(stockName))
                {
                    stocksDatabase[stockName] = new decimal[2];
                }

                stocksDatabase[stockName][0] = itemPrice;
                stocksDatabase[stockName][1] += itemQuantity;

                stockInfo = Console.ReadLine();
            }

            foreach (var stock in stocksDatabase)
            {
                decimal stockPrice = stock.Value[0] * stock.Value[1];

                grandTotal += stockPrice;

                Console.WriteLine($"{stock.Key}: ${stock.Value[0]:f2} * " +
                                  $"{stock.Value[1]} = ${stockPrice:f2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}