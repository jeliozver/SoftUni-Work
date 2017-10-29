namespace P04_Pokemon_Evolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public class Evolution
        {
            public string Type { get; set; }

            public int Index { get; set; }
        }

        public static void Main()
        {
            string currentInputLine = Console.ReadLine();

            var pokemonEvolutions = new Dictionary<string, List<Evolution>>();
            var splitter = new Regex(@"\s->\s");

            while (currentInputLine != "wubbalubbadubdub")
            {
                string[] arguments = splitter
                    .Split(currentInputLine)
                    .ToArray();

                if (arguments.Length == 1)
                {
                    if(pokemonEvolutions.ContainsKey(arguments[0]))
                    {
                        foreach (var pokemon in pokemonEvolutions)
                        {
                            if (pokemon.Key != arguments[0]) continue;
                            Console.WriteLine($"# {pokemon.Key}");

                            foreach (var evolution in pokemon.Value)
                            {
                                Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                            }

                            break;
                        }
                    }
                }
                else
                {
                    var currentEvolution = new Evolution();
                    currentEvolution.Type = arguments[1];
                    currentEvolution.Index = int.Parse(arguments[2]);

                    if (!pokemonEvolutions.ContainsKey(arguments[0]))
                    {
                        pokemonEvolutions[arguments[0]] = new List<Evolution>();
                    }

                    pokemonEvolutions[arguments[0]].Add(currentEvolution);
                }

                currentInputLine = Console.ReadLine();
            }

            foreach (var pokemon in pokemonEvolutions)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value
                        .OrderByDescending(i => i.Index))
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }
}