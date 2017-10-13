namespace P01_Phonebook
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

            var phonebook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                string name = command[1];

                if (command[0] == "A")
                {
                    string number = command[2];
                    phonebook[name] = number;
                }
                else if (command[0] == "S")
                {
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

                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }
    }
}