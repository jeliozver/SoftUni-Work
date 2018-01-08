namespace P02_Snowmen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                List<int> snowmen = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                HashSet<int> lostIndexes = new HashSet<int>();
                List<int> remainingSnowmen = new List<int>();

                while (true)
                {
                    for (int i = 0; i < snowmen.Count; i++)
                    {
                        if (snowmen.Count - lostIndexes.Count == 1)
                        {
                            return;
                        }

                        int attackerIndex = i;
                        int targetIndex = snowmen[i];

                        if (targetIndex >= snowmen.Count)
                        {
                            targetIndex %= snowmen.Count;
                        }

                        if (!lostIndexes.Contains(attackerIndex))
                        {
                            int difference = Math.Abs(attackerIndex - targetIndex);

                            if (attackerIndex == targetIndex)
                            {
                                // equal harakiri
                                lostIndexes.Add(attackerIndex);
                                Console.WriteLine($"{attackerIndex} performed harakiri");
                            }
                            else if (difference % 2 == 0)
                            {
                                // even attacker wins
                                lostIndexes.Add(targetIndex);
                                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                            }
                            else
                            {
                                // odd target wins
                                lostIndexes.Add(attackerIndex);
                                Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                            }
                        }
                    }

                    // Remove lost or suicided
                    remainingSnowmen.AddRange(snowmen.Where((t, i) => !lostIndexes.Contains(i)));

                    snowmen = remainingSnowmen;
                    lostIndexes = new HashSet<int>();
                    remainingSnowmen = new List<int>();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}