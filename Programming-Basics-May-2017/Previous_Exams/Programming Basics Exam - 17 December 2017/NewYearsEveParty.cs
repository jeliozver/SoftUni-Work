namespace PB_Dec_2_2017_2_New_Years_Eve_Party
{
    using System;

    public class NewYearsEveParty
    {
        public static void Main()
        {
            int guestsCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int couvertPrice = guestsCount * 20;

            if (budget >= couvertPrice)
            {
                int budgetLeft = budget - couvertPrice; 
                double fireworksMoney = Math.Ceiling(budgetLeft * 0.40);
                int charityMoney = budgetLeft - (int)fireworksMoney;

                Console.WriteLine($"Yes! {fireworksMoney} lv are for fireworks and {charityMoney} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {couvertPrice - budget} lv more.");
            }
        }
    }
}