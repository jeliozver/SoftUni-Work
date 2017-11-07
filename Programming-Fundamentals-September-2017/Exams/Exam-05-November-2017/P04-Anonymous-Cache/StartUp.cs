namespace P04_Anonymous_Cache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Data
    {
        public string Key { get; set; }
        public ulong Size { get; set; }
    }

    public class StartUp
    {
        public static void Main()
        {
            string info = Console.ReadLine();

            var dataSets = new Dictionary<string, List<Data>>();
            var cache = new Dictionary<string, List<Data>>();

            while (info != "thetinggoesskrra")
            {
                

                if (info.Contains('|'))
                {
                    string[] args = info
                        .Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string dataKey = args[0];
                    ulong dataSize = ulong.Parse(args[1]);
                    string dataSet = args[2];

                    if (dataSets.ContainsKey(dataSet))
                    {
                        var data = new Data();
                        data.Key = dataKey;
                        data.Size = dataSize;

                        dataSets[dataSet].Add(data);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache[dataSet] = new List<Data>();
                        }

                        var data = new Data();
                        data.Key = dataKey;
                        data.Size = dataSize;

                        cache[dataSet].Add(data);
                    }
                }
                else
                {
                    string dataSet = info;

                    if (!dataSets.ContainsKey(dataSet))
                    {
                        dataSets[dataSet] = new List<Data>();
                    }

                    if (cache.ContainsKey(dataSet))
                    {
                        foreach (var item in cache[dataSet])
                        {
                            dataSets[dataSet].Add(item);
                        }
                    }
                }

                info = Console.ReadLine();
            }

            if (!dataSets.Any())
            {
                return;
            }

            ulong biggestSum = 0;
            string dataSetBiggestSum = string.Empty;

            foreach (var set in dataSets)
            {
                ulong currentsum = 0;

                foreach (var item in set.Value)
                {
                    currentsum += item.Size;
                }

                if (currentsum > biggestSum)
                {
                    biggestSum = currentsum;
                    dataSetBiggestSum = set.Key;
                }
            }

            foreach (var set in dataSets)
            {
                if (set.Key == dataSetBiggestSum)
                {
                    Console.WriteLine($"Data Set: {set.Key}, Total Size: {biggestSum}");

                    foreach (var item in set.Value)
                    {
                        Console.WriteLine($"$.{item.Key}");
                    }
                }
            }
        }
    }
}