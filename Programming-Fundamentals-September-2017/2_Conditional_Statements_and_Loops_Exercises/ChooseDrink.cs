using System;

namespace Choose_a_Drink
{
    class ChooseDrink
    {
        static void Main(string[] args)
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