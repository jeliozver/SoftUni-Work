using System;

namespace PB_NovM_2016_1_Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            decimal skumriyaPrice = decimal.Parse(Console.ReadLine());
            decimal triconaPrice = decimal.Parse(Console.ReadLine());
            decimal palamudAmount = decimal.Parse(Console.ReadLine());
            decimal safridAmount = decimal.Parse(Console.ReadLine());
            int midiAmount = int.Parse(Console.ReadLine());

            decimal palamudPrice = skumriyaPrice + (skumriyaPrice * 0.60m);
            decimal safridPrice = triconaPrice + (triconaPrice * 0.80m);
            decimal midiPrice = 7.50m;

            decimal palamudTotal = palamudAmount * palamudPrice;
            decimal safridTotal = safridAmount * safridPrice;
            decimal midiTotal = midiAmount * midiPrice;
            decimal grandTotal = palamudTotal + safridTotal + midiTotal;

            Console.WriteLine(Math.Round(grandTotal, 2));
        }
    }
}
