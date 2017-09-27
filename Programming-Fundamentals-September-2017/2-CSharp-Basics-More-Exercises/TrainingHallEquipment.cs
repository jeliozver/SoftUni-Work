using System;

namespace Training_Hall_Equipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int itemsToBuy = int.Parse(Console.ReadLine());

            decimal totalCost = 0.00m;

            for (int i = 1; i <= itemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                int itemQuantity = int.Parse(Console.ReadLine());

                if (itemQuantity != 1)
                {
                   Console.WriteLine($"Adding {itemQuantity} {itemName}s to cart.");
                   totalCost += itemPrice * itemQuantity;
                }
                else
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName} to cart.");
                    totalCost += itemPrice * itemQuantity;
                }
            }

            Console.WriteLine($"Subtotal: ${totalCost:f2}");

            if (budget >= totalCost)
            {
                decimal moneyLeft = budget - totalCost;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                decimal moneyRequired = totalCost - budget;
                Console.WriteLine($"Not enough. We need ${moneyRequired:f2} more.");
            }
        }
    }
}