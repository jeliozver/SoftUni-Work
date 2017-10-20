namespace P07_Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] phrases = File.ReadAllLines("Phrases.txt");

            string[] events = File.ReadAllLines("Events.txt");

            string[] authors = File.ReadAllLines("Authors.txt");

            string[] cities = File.ReadAllLines("Cities.txt");

            Random randomizer = new Random();

            int messagesToGenerate = int.Parse(File.ReadAllText("MessagesToGenerate.txt"));

            var result = new List<string>();

            for (int i = 0; i < messagesToGenerate; i++)
            {
                int phrasesIndex = randomizer.Next(0, phrases.Length);
                int eventsIndex = randomizer.Next(0, events.Length);
                int authorsIndex = randomizer.Next(0, authors.Length);
                int citiesIndex = randomizer.Next(0, cities.Length);

                string message = $"{phrases[phrasesIndex]} " +
                                 $"{events[eventsIndex]} " +
                                 $"{authors[authorsIndex]} -" +
                                 $" {cities[citiesIndex]}";

                result.Add(message);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}