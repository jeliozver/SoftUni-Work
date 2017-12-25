namespace PB_Dec_2017_2_Deer_of_Santa
{
    using System;

    public class DeerOfSanta
    {
        public static void Main()
        {
            int daysSantaGone = int.Parse(Console.ReadLine());
            int foodAmount = int.Parse(Console.ReadLine());
            double firstDeerFoodPerDay = double.Parse(Console.ReadLine());
            double secondDeerFoodPerDay = double.Parse(Console.ReadLine());
            double thirdDeerFoodPerDay = double.Parse(Console.ReadLine());

            double firstDeerFoodNeeded = daysSantaGone * firstDeerFoodPerDay;
            double secondDeerFoodNeeded = daysSantaGone * secondDeerFoodPerDay;
            double thirdDeerFoodNeeded = daysSantaGone * thirdDeerFoodPerDay;

            double totalFood = firstDeerFoodNeeded + secondDeerFoodNeeded + thirdDeerFoodNeeded;

            Console.WriteLine(foodAmount >= totalFood
                ? $"{Math.Floor(foodAmount - totalFood)} kilos of food left."
                : $"{Math.Ceiling(totalFood - foodAmount)} more kilos of food are needed.");
        }
    }
}