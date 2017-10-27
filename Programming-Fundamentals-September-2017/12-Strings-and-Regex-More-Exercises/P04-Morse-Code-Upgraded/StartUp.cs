namespace P04_Morse_Code_Upgraded
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string encryptedMessage = Console.ReadLine();

            string[] encryptedLetters = encryptedMessage
                .Split('|')
                .ToArray();

            var result = new StringBuilder();
            string zeroesSequencePattern = @"([0]{2,})";
            string onesSequencePattern = @"([1]{2,})";

            foreach (string message in encryptedLetters)
            {
                int zeroesCount = 0;
                int onesCount = 0;
                int sequencesSum = 0;

                foreach (char letter in message)
                {
                    int currentNum = int.Parse(letter.ToString());

                    switch (currentNum)
                    {
                        case 0:
                            zeroesCount++;
                            break;

                        case 1:
                            onesCount++;
                            break;
                    }
                }

                var zeroesMatches = Regex.Matches(message, zeroesSequencePattern);
                var onesMatches = Regex.Matches(message, onesSequencePattern);

                if (zeroesMatches.Count != 0)
                {
                    foreach (Match match in zeroesMatches)
                    {
                        sequencesSum += match.Value.Length;
                    }
                }

                if (onesMatches.Count != 0)
                {
                    foreach (Match match in onesMatches)
                    {
                        sequencesSum += match.Value.Length;
                    }
                }

                int sum = zeroesCount * 3 + onesCount * 5 + sequencesSum;
                char currentLetter = (char)sum;
                result.Append(currentLetter);
            }

            Console.WriteLine(result.ToString());
        }
    }
}