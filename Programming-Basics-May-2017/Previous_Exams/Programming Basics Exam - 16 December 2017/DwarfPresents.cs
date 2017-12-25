namespace PB_Dec_2017_4_Dwarf_Presents
{
    using System;

    public class DwarfPresents
    {
        public static void Main()
        {
            int dwarfsCount = int.Parse(Console.ReadLine());
            int santaMoney = int.Parse(Console.ReadLine());

            int sandclocksCount = 0;
            int magnetsCount = 0;
            int cupsCount = 0;
            int tshirtsCount = 0;

            for (int i = 0; i < dwarfsCount; i++)
            {
                string currentPresent = Console.ReadLine();

                if (currentPresent == "sand clock")
                {
                    sandclocksCount++;
                }
                else if (currentPresent == "magnet")
                {
                    magnetsCount++;
                }
                else if (currentPresent == "cup")
                {
                    cupsCount++;
                }
                else if (currentPresent == "t-shirt")
                {
                    tshirtsCount++;
                }
            }

            decimal sandclocksPrice = 2.20m * sandclocksCount;
            decimal magnetsPrice = 1.50m * magnetsCount;
            decimal cupsPrice = 5.00m * cupsCount;
            decimal tshirtsPrice = 10.00m * tshirtsCount;

            decimal totalPrice = sandclocksPrice + magnetsPrice + cupsPrice + tshirtsPrice;

            Console.WriteLine(santaMoney >= totalPrice
                ? $"Santa Claus has {santaMoney - totalPrice:f2} more leva left!"
                : $"Santa Claus will need {totalPrice - santaMoney:f2} more leva.");
        }
    }
}