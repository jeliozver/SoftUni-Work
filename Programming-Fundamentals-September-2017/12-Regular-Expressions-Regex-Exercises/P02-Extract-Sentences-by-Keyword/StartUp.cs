namespace P02_Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"[^.?!]*(?<=[.?\W0-9]){keyword}(?=[0-9\W.?!])[^.?!]*[.?!]";

            var matchedSentences = Regex.Matches(text, pattern);

            foreach (Match match in matchedSentences)
            {
                string result = match.Value.TrimStart(' ', '\t');
                result = result.Remove(result.Length - 1);
                Console.WriteLine(result);
            }
        }
    }
}