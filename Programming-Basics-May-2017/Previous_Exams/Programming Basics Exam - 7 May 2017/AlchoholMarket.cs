using System;

namespace PB_May_2017_1_Alcohol_Market
{
    class AlchoholMarket
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiyaLiters = double.Parse(Console.ReadLine());
            double whiskyLiters = double.Parse(Console.ReadLine());

            double rakiyaPrice = whiskyPrice / 2;
            double winePrice = rakiyaPrice - (0.4 * rakiyaPrice);
            double beerPrice = rakiyaPrice - (0.8 * rakiyaPrice);

            double rakiyaTotal = rakiyaLiters * rakiyaPrice;
            double wineTotal = wineLiters * winePrice;
            double beerTotal = beerLiters * beerPrice;
            double whiskyTotal = whiskyLiters * whiskyPrice;
            double totalSum = rakiyaTotal + wineTotal + beerTotal + whiskyTotal;

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
