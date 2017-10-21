namespace P02_Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var carsList = new List<Car>();
            var trucksList = new List<Truck>();

            string currentInput = Console.ReadLine();

            while (currentInput != "End")
            {
                string[] arguments = currentInput
                    .Split(' ')
                    .ToArray();

                if (arguments[0].ToLower() == "truck")
                {
                    var currentTruck = new Truck
                    {
                        Model = arguments[1],
                        Color = arguments[2],
                        Horsepower = double.Parse(arguments[3])
                    };

                    trucksList.Add(currentTruck);
                }
                else
                {
                    var currentCar = new Car
                    {
                        Model = arguments[1],
                        Color = arguments[2],
                        Horsepower = double.Parse(arguments[3])
                    };

                    carsList.Add(currentCar);
                }

                currentInput = Console.ReadLine();
            }

            string currentModel = Console.ReadLine();

            while (currentModel != "Close the Catalogue")
            {
                foreach (var car in carsList)
                {
                    if (car.Model.Equals(currentModel))
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Horsepower}");
                        break;
                    }
                }

                foreach (var truck in trucksList)
                {
                    if (truck.Model.Equals(currentModel))
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");
                        break;
                    }
                }

                currentModel = Console.ReadLine();
            }

            double carsAvgHp = 0d;
            double trucksAvgHp = 0d;

            double carsHp = carsList.Sum(hp => hp.Horsepower);

            if (carsHp > 0)
            {
                carsAvgHp = carsHp / carsList.Count;
            }

            double trucksHp = trucksList.Sum(hp => hp.Horsepower);

            if (trucksHp > 0)
            {
                trucksAvgHp = trucksHp / trucksList.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");
        }
    }
}