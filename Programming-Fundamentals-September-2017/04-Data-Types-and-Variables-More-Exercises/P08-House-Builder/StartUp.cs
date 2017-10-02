namespace P08_House_Builder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int priceOne = int.Parse(Console.ReadLine());
            int PriceTwo = int.Parse(Console.ReadLine());

            long intPrice = (long)Math.Max(priceOne, PriceTwo) * 10;
            long sbytePrice = (long)Math.Min(priceOne, PriceTwo) * 4;

            long totalPrice = intPrice + sbytePrice;

            Console.WriteLine(totalPrice);
        }
    }
}