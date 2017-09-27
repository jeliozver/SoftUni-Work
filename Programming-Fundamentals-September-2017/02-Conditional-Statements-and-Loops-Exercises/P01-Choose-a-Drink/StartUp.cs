namespace P01_Choose_a_Drink
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string profession = Console.ReadLine();

            string perfectDrink = string.Empty;

            if (profession == "Athlete")
            {
                perfectDrink = "Water";
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                perfectDrink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                perfectDrink = "Beer";
            }
            else
            {
                perfectDrink = "Tea";
            }

            Console.WriteLine(perfectDrink);
        }
    }
}
