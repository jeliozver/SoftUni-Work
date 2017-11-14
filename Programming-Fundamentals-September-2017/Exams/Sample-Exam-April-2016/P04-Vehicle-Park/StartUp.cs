namespace P04_Vehicle_Park
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> vehiclesList = Console.ReadLine()
                .Split(' ')
                .ToList();

            string request = Console.ReadLine();
            int vehiclesSoldCount = 0;

            while (request != "End of customers!")
            {
                string[] args = request
                    .Split(' ')
                    .ToArray();

                string searchVehicle = args[0][0]
                    .ToString()
                    .ToLower()
                    + args[2];

                bool isVehicleFound = false;

                for (int i = 0; i < vehiclesList.Count; i++)
                {
                    if (vehiclesList[i] == searchVehicle)
                    {
                        decimal sellPrice = searchVehicle[0] * int.Parse(args[2]);
                        Console.WriteLine($"Yes, sold for {sellPrice}$");
                        vehiclesList.Remove(searchVehicle);
                        isVehicleFound = true;
                        vehiclesSoldCount++;
                        break;
                    }
                }

                if (!isVehicleFound)
                {
                    Console.WriteLine("No");
                }

                request = Console.ReadLine();
            }

            Console.WriteLine($"Vehicles left: {string.Join(", ", vehiclesList)}");
            Console.WriteLine($"Vehicles sold: {vehiclesSoldCount}");
        }
    }
}