namespace P03_Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string matchText = Console.ReadLine();

            string bojomonPattern = @"[A-Za-z]+-[A-Za-z]+";
            string didimonPattern = @"[^-a-zA-Z]+";

            while (matchText != string.Empty)
            {
                if (Regex.IsMatch(matchText, didimonPattern))
                {
                    var didimonMatch = Regex.Match(matchText, didimonPattern);
                    Console.WriteLine(didimonMatch.Value);

                    int didimonMatchStartIndex = matchText.IndexOf(didimonMatch.Value);
                    matchText = matchText.Remove(0, didimonMatchStartIndex + didimonMatch.Length);
                }
                else
                {
                    break;
                }

                if (Regex.IsMatch(matchText, bojomonPattern))
                {
                    var bojomonMatch = Regex.Match(matchText, bojomonPattern);
                    Console.WriteLine(bojomonMatch.Value);

                    int bojomonMatchStartIndex = matchText.IndexOf(bojomonMatch.Value);
                    matchText = matchText.Remove(0, bojomonMatchStartIndex + bojomonMatch.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}