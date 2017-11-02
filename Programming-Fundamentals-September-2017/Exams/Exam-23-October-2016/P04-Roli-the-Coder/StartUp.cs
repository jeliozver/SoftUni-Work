namespace P04_Roli_the_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var idAndName = new Dictionary<string, HashSet<string>>();
            var eventNamesParticipants = new SortedDictionary<string, List<string>>();

            string validInputPattern = @"((\d+)\s+(\#\w+)\s+)(\@\w+\s+|\@\w+)*";

            string input = Console.ReadLine();

            while (input != "Time for Code")
            {
                input = input + " ";
                var validInput = Regex.Match(input, validInputPattern);

                if (validInput.Success)
                {
                    string id = validInput.Groups[2].Value;
                    string eventName = validInput.Groups[3].Value;
                    string currentParticipants = Regex.Replace(input, validInput.Groups[1].Value, "");

                    if (idAndName.ContainsKey(id))
                    {
                        if (idAndName[id].Contains(eventName))
                        {
                            AddNamesAndSort(eventName, currentParticipants, eventNamesParticipants);
                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        if (!idAndName.ContainsKey(id))
                        {
                            idAndName[id] = new HashSet<string>();
                        }

                        idAndName[id].Add(eventName);

                        if (!eventNamesParticipants.ContainsKey(eventName))
                        {
                            eventNamesParticipants[eventName] = new List<string>();
                        }

                        AddNamesAndSort(eventName, currentParticipants, eventNamesParticipants);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = eventNamesParticipants
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(k => k.Key, val => val.Value);

            foreach (var eventName in sorted)
            {
                Console.WriteLine($"{eventName.Key.TrimStart('#')} - {eventName.Value.Count}");

                foreach (var name in eventName.Value)
                {
                    Console.WriteLine($"{name}");
                }
            }
        }

        public static void AddNamesAndSort(string name, string participants, 
            SortedDictionary<string, List<string>> eventNamesParticipants)
        {
            string[] args = participants
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string n in args)
            {
                if (!eventNamesParticipants[name].Contains(n))
                {
                    eventNamesParticipants[name].Add(n);
                }
            }

            eventNamesParticipants[name].Sort();
        }
    }
}