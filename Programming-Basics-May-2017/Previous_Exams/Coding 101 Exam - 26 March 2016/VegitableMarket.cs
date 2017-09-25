using System;

namespace PB_March_2_2016_1_Vegitable_Market
{
    class VegitableMarket
    {
        static void Main(string[] args)
        {
            var vegitablesPriceKg = double.Parse(Console.ReadLine());
            var fruitsPriceKg = double.Parse(Console.ReadLine());

            var vegitablesWeight = int.Parse(Console.ReadLine());
            var fruitsWeight = int.Parse(Console.ReadLine());

            var vegitablesPriceFinal = vegitablesPriceKg * vegitablesWeight;
            var fruitsPriceFinal = fruitsPriceKg * fruitsWeight;

            var profit = (vegitablesPriceFinal + fruitsPriceFinal) / 1.94;

            Console.WriteLine(profit);
        }
    }
}
