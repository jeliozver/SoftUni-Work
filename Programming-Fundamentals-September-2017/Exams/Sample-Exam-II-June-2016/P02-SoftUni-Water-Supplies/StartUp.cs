namespace P02_SoftUni_Water_Supplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            decimal waterAmount = decimal.Parse(Console.ReadLine());
            decimal[] bottles = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();
            decimal bottleCapacity = decimal.Parse(Console.ReadLine());

            bool isWaterEnough = true;
            var notFullIndexes = new List<int>();
            decimal waterNeeded = 0;

            if (waterAmount % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    if (waterAmount - (bottleCapacity - bottles[i]) < 0)
                    {
                        bottles[i] += waterAmount;
                        isWaterEnough = false;
                        break;
                    }

                    if (bottles[i] != bottleCapacity)
                    {
                        waterAmount -= bottleCapacity - bottles[i];
                        bottles[i] = bottleCapacity;
                    }
                }

                if (!isWaterEnough)
                {
                    for (int i = 0; i < bottles.Length; i++)
                    {
                        if (bottles[i] != bottleCapacity)
                        {
                            waterNeeded += bottleCapacity - bottles[i];
                            notFullIndexes.Add(i);
                        }
                    }
                }
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    if (waterAmount - (bottleCapacity - bottles[i]) < 0)
                    {
                        bottles[i] += waterAmount;
                        isWaterEnough = false;
                        break;
                    }

                    if (bottles[i] != bottleCapacity)
                    {
                        waterAmount -= bottleCapacity - bottles[i];
                        bottles[i] = bottleCapacity;
                    }
                }

                if (!isWaterEnough)
                {
                    for (int i = bottles.Length - 1; i >= 0; i--)
                    {
                        if (bottles[i] != bottleCapacity)
                        {
                            waterNeeded += bottleCapacity - bottles[i];
                            notFullIndexes.Add(i);
                        }
                    }
                }
            }

            if (isWaterEnough)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {waterAmount}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {notFullIndexes.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", notFullIndexes)}");
                Console.WriteLine($"We need {waterNeeded} more liters!");
            }
        }
    }
}