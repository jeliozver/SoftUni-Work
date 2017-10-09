namespace P08_Upgraded_Matcher
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] products = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            long[] quantities = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            decimal[] prices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            string productName = Console.ReadLine();
            Array.Resize(ref quantities, products.Length);

            while (productName != "done")
            {
                string[] args = productName.Split(' ').ToArray();
                string product = args[0];
                long orderQuantity = long.Parse(args[1]);
                int index = Array.IndexOf(products, product);

                if (quantities[index] >= orderQuantity)
                {
                    quantities[index] -= orderQuantity;
                    decimal orderCost = prices[index] * orderQuantity;
                    Console.WriteLine($"{product} x {orderQuantity} costs {orderCost:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product}");
                }

                productName = Console.ReadLine();
            }
        }
    }
}