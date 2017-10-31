namespace P01_Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            decimal totalSum = 0m;

            int ordersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(
                    Console.ReadLine(),
                    "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal currentPrice = (decimal)daysInMonth * capsulesCount * pricePerCapsule;

                totalSum += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}