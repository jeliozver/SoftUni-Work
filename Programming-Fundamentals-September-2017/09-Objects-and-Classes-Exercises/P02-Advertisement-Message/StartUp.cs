using System;

namespace P02_Advertisement_Message
{
    public class StartUp
    {
        public static void Main()
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random randomizer = new Random();

            int messagesToGenerate = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesToGenerate; i++)
            {
                int phrasesIndex = randomizer.Next(0, phrases.Length);
                int eventsIndex = randomizer.Next(0, events.Length);
                int authorsIndex = randomizer.Next(0, authors.Length);
                int citiesIndex = randomizer.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrasesIndex]} " +
                                  $"{events[eventsIndex]} " +
                                  $"{authors[authorsIndex]} - " +
                                  $"{cities[citiesIndex]}.");
            }
        }
    }
}