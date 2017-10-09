namespace P07_Inventory_Matcher
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

            while (productName != "done")
            {
                int index = Array.IndexOf(products, productName);

                Console.WriteLine($"{productName} costs: {prices[index]}; " +
                                  $"Available quantity: {quantities[index]}");
                productName = Console.ReadLine();
            }
        }
    }
}