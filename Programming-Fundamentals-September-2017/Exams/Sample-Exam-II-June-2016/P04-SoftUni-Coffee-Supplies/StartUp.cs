namespace P04_SoftUni_Coffee_Supplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string[] delimeters = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string delimiterOne = Regex.Escape(delimeters[0]);
            string delimiterTwo = Regex.Escape(delimeters[1]);
            string personName = string.Empty;
            string coffeeType = string.Empty;
            long coffeeQuantity;

            var coffeeTypeName = new SortedDictionary<string, List<string>>();
            var coffeeTypeQuantity = new Dictionary<string, long>();

            string currentInfo = Console.ReadLine();

            while (currentInfo != "end of info")
            {
                var matchOne = Regex
                    .Match(currentInfo, $@"(.*)({delimiterOne})(.*)");
                var matchTwo = Regex
                    .Match(currentInfo, $@"(.*)({delimiterTwo})(.*)");

                if (matchOne.Success)
                {
                    personName = matchOne.Groups[1].Value;
                    coffeeType = matchOne.Groups[3].Value;

                    if (!coffeeTypeName.ContainsKey(coffeeType))
                    {
                        coffeeTypeName[coffeeType] = new List<string>();
                    }

                    if (!coffeeTypeQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeQuantity[coffeeType] = 0L;
                    }

                    coffeeTypeName[coffeeType].Add(personName);
                }
                else
                {
                    coffeeType = matchTwo.Groups[1].Value;
                    coffeeQuantity = 0L;

                    if (matchTwo.Groups[3].Value != string.Empty)
                    {
                        coffeeQuantity = long.Parse(matchTwo.Groups[3].Value);
                    }

                    if (!coffeeTypeQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeQuantity[coffeeType] = 0L;
                    }

                    coffeeTypeQuantity[coffeeType] += coffeeQuantity;
                }

                currentInfo = Console.ReadLine();
            }

            foreach (var type in coffeeTypeQuantity)
            {
                if (type.Value == 0)
                {
                    Console.WriteLine($"Out of {type.Key}");
                }
            }

            currentInfo = Console.ReadLine();

            while (currentInfo != "end of week")
            {
                string[] args = currentInfo
                    .Split(' ')
                    .ToArray();

                personName = args[0];
                coffeeQuantity = long.Parse(args[1]);

                foreach (var type in coffeeTypeName)
                {
                    foreach (var name in type.Value)
                    {
                        if (name == personName)
                        {
                            coffeeTypeQuantity[type.Key] -= coffeeQuantity;
                            if (coffeeTypeQuantity[type.Key] <= 0)
                            {
                                Console.WriteLine($"Out of {type.Key}");
                            }
                        }
                    }
                }

                currentInfo = Console.ReadLine();
            }

            coffeeTypeQuantity = coffeeTypeQuantity
                .Where(v => v.Value > 0)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Coffee Left:");
            foreach (var type in coffeeTypeQuantity.OrderByDescending(v => v.Value))
            {
                Console.WriteLine($"{type.Key} {type.Value}");
            }

            Console.WriteLine("For:");
            foreach (var type in coffeeTypeName)
            {
                foreach (var name in type.Value.OrderByDescending(v => v))
                {
                    if (coffeeTypeQuantity.ContainsKey(type.Key))
                    {
                        Console.WriteLine($"{name} {type.Key}");
                    }
                }
            }
        }
    }
}