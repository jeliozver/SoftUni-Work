namespace P01_Sweet_Dessert
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal totalCash = decimal.Parse(Console.ReadLine());
            int guestsCount = int.Parse(Console.ReadLine());
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerriesKg = decimal.Parse(Console.ReadLine());

            decimal portionsNeeded = Math.Ceiling((decimal)guestsCount / 6);

            decimal moneyNeeded = portionsNeeded * (2 * priceBanana)
                                  + portionsNeeded * (4 * priceEggs)
                                  + portionsNeeded * (0.2m * priceBerriesKg);

            if (moneyNeeded <= totalCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                decimal neededMoney = moneyNeeded - totalCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}