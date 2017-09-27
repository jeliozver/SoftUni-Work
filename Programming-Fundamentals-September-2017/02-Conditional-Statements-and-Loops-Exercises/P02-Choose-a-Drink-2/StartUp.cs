namespace P02_Choose_a_Drink_2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            double drinkQuantity = double.Parse(Console.ReadLine());

            double drinkPrice = 0.00;

            if (profession == "Athlete")
            {
                drinkPrice = drinkQuantity * 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drinkPrice = drinkQuantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {

                drinkPrice = drinkQuantity * 1.70;
            }
            else
            {
                drinkPrice = drinkQuantity * 1.20;
            }

            Console.WriteLine($"The {profession} has to pay {drinkPrice:f2}.");

        }
    }
}
