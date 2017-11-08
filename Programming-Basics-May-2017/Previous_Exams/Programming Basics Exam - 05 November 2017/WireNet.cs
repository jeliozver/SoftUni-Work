namespace PB_November_2017_1_Wire_Net
{
    using System;

    public class WireNet
    {
        public static void Main()
        {
            int placeHeight = int.Parse(Console.ReadLine());
            int placeWidth = int.Parse(Console.ReadLine());
            decimal fenceHeight = decimal.Parse(Console.ReadLine());
            decimal fencePrice = decimal.Parse(Console.ReadLine());
            decimal fenceWeight = decimal.Parse(Console.ReadLine());

            int fenceLenght = 2 * placeHeight + 2 * placeWidth;
            decimal fenceTotalPrice = fenceLenght * fencePrice;
            decimal fenceArea = fenceLenght * fenceHeight;
            decimal fenceTotalWeight = fenceArea * fenceWeight;

            Console.WriteLine(fenceLenght);
            Console.WriteLine($"{fenceTotalPrice:f2}");
            Console.WriteLine($"{fenceTotalWeight:f3}");
        }
    }
}