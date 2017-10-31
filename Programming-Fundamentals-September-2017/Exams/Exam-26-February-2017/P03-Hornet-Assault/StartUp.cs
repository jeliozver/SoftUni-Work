namespace P03_Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long[] beeHives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var test = new List<long>();

            for (int hive = 0; hive < beeHives.Length; hive++)
            {
                var currentHornetsPower = 0L;

                foreach (var hornet in hornets)
                {
                    currentHornetsPower += hornet;
                }

                if (beeHives[hive] >= currentHornetsPower && hornets.Count != 0)
                {
                    hornets.RemoveAt(0);
                }

                if (beeHives[hive] - currentHornetsPower > 0)
                {
                    test.Add(beeHives[hive] - currentHornetsPower);
                }
            }

            if (test.Count > 0)
            {
                Console.WriteLine(string.Join(" ", test));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}