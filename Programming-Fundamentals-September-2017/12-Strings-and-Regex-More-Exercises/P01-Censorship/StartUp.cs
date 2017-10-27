namespace P01_Censorship
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string censorWord = Console.ReadLine();
            string sentence = Console.ReadLine();

            string replacePattern = $@"{censorWord}";
            string censorship = new string('*', censorWord.Length);

            string censoredSentence = Regex
                .Replace(sentence, replacePattern,censorship);

            Console.WriteLine(censoredSentence);
        }
    }
}