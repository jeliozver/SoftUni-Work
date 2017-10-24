namespace P03_Text_Filter
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string bannedWords = Console.ReadLine();

            string[] banned = Regex.Split(bannedWords, ", ");

            string text = Console.ReadLine();

            foreach (var word in banned)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}