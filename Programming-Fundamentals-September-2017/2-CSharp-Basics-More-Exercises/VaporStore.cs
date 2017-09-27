using System;

namespace Vapor_Store
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            decimal startBudget = decimal.Parse(Console.ReadLine());
            string currentGame = Console.ReadLine();

            decimal outFallPrice = 39.99m;
            decimal csPrice = 15.99m;
            decimal zplinterZellPrice = 19.99m;
            decimal honoredTwoPrice = 59.99m;
            decimal roverWatchPrice = 29.99m;
            decimal roverWatchOriginsPrice = 39.99m;
            decimal currentBudget = startBudget;

            while (currentGame != "Game Time")
            {
                bool isGameFound = true;
                decimal currentPrice = 0.00m;

                switch (currentGame)
                {
                    case "OutFall 4": currentPrice = outFallPrice; break;
                    case "CS: OG": currentPrice = csPrice; break;
                    case "Zplinter Zell": currentPrice = zplinterZellPrice; break;
                    case "Honored 2": currentPrice = honoredTwoPrice; break;
                    case "RoverWatch": currentPrice = roverWatchPrice; break;
                    case "RoverWatch Origins Edition": currentPrice = roverWatchOriginsPrice; break;
                    default: isGameFound = false; break;
                }

                currentBudget -= currentPrice;

                if (!isGameFound)
                {
                    Console.WriteLine("Not Found");
                }
                else if (currentBudget == 0)
                {
                    Console.WriteLine($"Bought {currentGame}");
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (currentBudget < 0)
                {
                    Console.WriteLine("Too Expensive");
                    currentBudget += currentPrice;
                }
                else
                {
                    Console.WriteLine($"Bought {currentGame}");
                }

                currentGame = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${startBudget - currentBudget:f2}. Remaining: ${currentBudget:f2}");
        }
    }
}