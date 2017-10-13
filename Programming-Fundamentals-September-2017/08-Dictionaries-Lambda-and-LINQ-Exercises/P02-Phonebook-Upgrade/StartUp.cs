namespace P02_Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var phonebook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    string name = command[1];
                    string number = command[2];
                    phonebook[name] = number;
                }
                else if (command[0] == "S")
                {
                    string name = command[1];

                    if (phonebook.ContainsKey(name))
                    {
                        foreach (var n in phonebook)
                        {
                            if (n.Key == name)
                            {
                                Console.WriteLine($"{n.Key} -> {n.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var n in phonebook)
                    {
                        Console.WriteLine($"{n.Key} -> {n.Value}");
                    }
                }

                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }
    }
}