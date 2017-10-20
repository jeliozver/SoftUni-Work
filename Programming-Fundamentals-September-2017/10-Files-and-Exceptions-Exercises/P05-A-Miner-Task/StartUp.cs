namespace P05_A_Miner_Task
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = "Input.txt";

            var inputLines = File.ReadAllLines(input)
                .ToArray();
            int lastIndex = 0;

            string resource = inputLines[lastIndex++];
     

            var resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(inputLines[lastIndex++]);

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                resource = inputLines[lastIndex++];
            }

            var result = resources
                .Select(item => $"{item.Key} -> {item.Value}")
                .ToList();

            File.WriteAllLines("Output.txt", result);
        }
    }
}