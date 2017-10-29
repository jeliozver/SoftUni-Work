namespace P03_Endurance_Rally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine()
                .Split(' ')
                .ToArray();

            double[] trackLayout = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int[] checkpointIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var driversResults = new List<Driver>();

            foreach (var currentDriverName in participants)
            {
                int currentDriverFuel = Convert.ToInt32(currentDriverName[0]);
                double fuel = Convert.ToDouble(currentDriverFuel);
                bool isDriverFinished = true;
                var currentDriver = new Driver();

                for (int j = 0; j < trackLayout.Length; j++)
                {
                    if (checkpointIndexes.Contains(j))
                    {
                        fuel += trackLayout[j];

                        if (fuel <= 0)
                        {
                            currentDriver.Name = currentDriverName;
                            currentDriver.Result = " - reached ";
                            currentDriver.ResultValue = $"{j}";
                            isDriverFinished = false;
                            break;
                        }
                    }
                    else
                    {
                        fuel -= trackLayout[j];

                        if (fuel <= 0)
                        {
                            currentDriver.Name = currentDriverName;
                            currentDriver.Result = " - reached ";
                            currentDriver.ResultValue = $"{j}";
                            isDriverFinished = false;
                            break;
                        }
                    }
                }

                if (isDriverFinished)
                {
                    currentDriver.Name = currentDriverName;
                    currentDriver.Result = " - fuel left ";
                    currentDriver.ResultValue = $"{fuel:f2}";
                }

                driversResults.Add(currentDriver);
            }

            foreach (var driver in driversResults)
            {
                Console.WriteLine($"{driver.Name}" +
                                  $"{driver.Result}" +
                                  $"{driver.ResultValue}");
            }
        }
    }
}