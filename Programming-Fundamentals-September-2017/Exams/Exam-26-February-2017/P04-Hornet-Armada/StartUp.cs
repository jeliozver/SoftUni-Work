namespace P04_Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var legionsAndActivity = new Dictionary<string, int>();
            var legionsAndSoldiers = new Dictionary<string, Dictionary<string, long>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] currentInfo = Console.ReadLine()
                    .Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int lastActivity = int.Parse(currentInfo[0]);
                string legionName = currentInfo[1];
                string soldierType = currentInfo[2];
                long soldierCount = long.Parse(currentInfo[3]);

                if (!legionsAndActivity.ContainsKey(legionName))
                {
                    legionsAndActivity[legionName] = lastActivity;
                    legionsAndSoldiers[legionName] = new Dictionary<string, long>();
                }

                if (lastActivity > legionsAndActivity[legionName])
                {
                    legionsAndActivity[legionName] = lastActivity;
                }

                if (!legionsAndSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsAndSoldiers[legionName][soldierType] = 0L;
                }

                legionsAndSoldiers[legionName][soldierType] += soldierCount;
            }

            string[] command = Console.ReadLine()
                .Split('\\')
                .ToArray();

            if (command.Length == 2)
            {
                int givenActivity = int.Parse(command[0]);
                string soldiersToPrint = command[1];

                foreach (var legion in legionsAndSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldiersToPrint))
                    .OrderByDescending(c => c.Value[soldiersToPrint]))
                {
                    if (legionsAndActivity[legion.Key] < givenActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> " +
                                          $"{legionsAndSoldiers[legion.Key][soldiersToPrint]}");
                    }
                }
            }
            else
            {
                string soldiersToPrint = command[0];

                foreach (var legion in legionsAndActivity
                    .OrderByDescending(a => a.Value))
                {
                    if (legionsAndSoldiers[legion.Key].ContainsKey(soldiersToPrint))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}