namespace P08_Use_Your_Chains_Buddy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string htmlDocument = Console.ReadLine();

            string extractTextPattern = @"<p>(.*?)<\/p>";
            string replacePattern = @"\W|[A-Z]";

            var textLines = Regex.Matches(htmlDocument, extractTextPattern);
            var encryptedMessages = new List<string>();
            var decryptedMessages = new List<string>();

            foreach (Match match in textLines)
            {
                var removeJunk = Regex.Replace(match.Groups[1].Value, replacePattern, " ");
                removeJunk = Regex.Replace(removeJunk, @"\s+", " ");
                encryptedMessages.Add(removeJunk);
            }

            foreach (var message in encryptedMessages)
            {
                var builder = new StringBuilder();

                foreach (char letter in message)
                {
                    if (letter >= 97 && letter <= 109)
                    {
                        int convert = Convert.ToInt32(letter + 13);

                        builder.Append((char)convert);
                    }
                    else if (letter >= 110 && letter <= 122)
                    {
                        int convert = Convert.ToInt32(letter - 13);

                        builder.Append((char)convert);
                    }
                    else
                    {
                        builder.Append(letter);
                    }
                }

                decryptedMessages.Add(builder.ToString());
            }

            Console.WriteLine(string.Join("", decryptedMessages));
        }
    }
}