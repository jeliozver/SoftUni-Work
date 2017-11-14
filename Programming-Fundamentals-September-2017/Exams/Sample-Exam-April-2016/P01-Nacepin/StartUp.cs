namespace P01_Nacepin
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            decimal usPrice = decimal.Parse(Console.ReadLine());
            long usWeight = long.Parse(Console.ReadLine());
            decimal ukPrice = decimal.Parse(Console.ReadLine());
            long ukWeight = long.Parse(Console.ReadLine());
            decimal chnPrice = decimal.Parse(Console.ReadLine());
            long chnWeight = long.Parse(Console.ReadLine());

            decimal priceUsd = (usPrice / 0.58m) / usWeight;
            decimal priceGpb = (ukPrice / 0.41m) / ukWeight;
            decimal priceCny = (chnPrice * 0.27m) / chnWeight;
            decimal[] pricesList = { priceUsd, priceGpb, priceCny };
            decimal highestPrice = pricesList.Max();
            decimal lowestPrice = pricesList.Min();
            decimal difference = highestPrice - lowestPrice;
            string lowestPriceStore;

            if (lowestPrice == priceUsd)
            {
                lowestPriceStore = "US";
            }
            else if (lowestPrice == priceGpb)
            {
                lowestPriceStore = "UK";
            }
            else
            {
                lowestPriceStore = "Chinese";
            }

            Console.WriteLine($"{lowestPriceStore} store. {lowestPrice:f2} lv/kg");
            Console.WriteLine($"Difference {difference:f2} lv/kg");
        }
    }
}