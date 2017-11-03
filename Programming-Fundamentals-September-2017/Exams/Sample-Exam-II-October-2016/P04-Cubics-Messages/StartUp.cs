namespace P04_Cubics_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string currentMessage = Console.ReadLine();
            var validMessages = new List<string>();

            while (currentMessage != "Over!")
            {
                int lenght = int.Parse(Console.ReadLine());
                string pattern = $@"(^\d+)([A-Za-z]{{{lenght}}})([^A-Za-z]*$)";
                var match = Regex.Match(currentMessage, pattern);

                if (match.Success)
                {
                    string before = match.Groups[1].Value;
                    string extractedMessage = match.Groups[2].Value;
                    string after = match.Groups[3].Value;

                    var afterMatches = Regex.Matches(after, @"\d+");
                    string afterNumbersOnly = string.Empty;

                    foreach (Match m in afterMatches)
                    {
                        afterNumbersOnly = string.Concat(afterNumbersOnly, m);
                    }

                    string indexes = string.Concat(before, afterNumbersOnly);

                    string verificationCode = string.Empty;

                    for (int i = 0; i < indexes.Length; i++)
                    {
                        int index = int.Parse(indexes[i].ToString());

                        if (extractedMessage.Length - 1 >= index)
                        {
                            verificationCode = string.Concat(verificationCode, extractedMessage[index]);
                        }
                        else
                        {
                            verificationCode = string.Concat(verificationCode, " ");
                        }
                    }

                    string result = $"{extractedMessage} == {verificationCode}";
                    validMessages.Add(result);
                }

                currentMessage = Console.ReadLine();
            }

            foreach (var msg in validMessages)
            {
                Console.WriteLine(msg);
            }
        }
    }
}