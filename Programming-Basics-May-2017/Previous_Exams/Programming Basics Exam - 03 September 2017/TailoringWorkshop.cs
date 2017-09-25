using System;

namespace PB_Sep_2017_1_Tailoring_Workshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double tablesHeight = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            double tableCloakArea = tablesCount * (tablesHeight + 2 * 0.30) * (tablesWidth + 2 * 0.30);
            double caresArea = tablesCount * (tablesHeight / 2) * (tablesHeight / 2);

            double priceUSD = (tableCloakArea * 7) + (caresArea * 9);
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");
        }
    }
}
