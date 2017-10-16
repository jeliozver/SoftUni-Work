namespace P02_Randomize_Words
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            Random randomizer = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int randomIndex = randomizer.Next(0, words.Length);

                string tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}