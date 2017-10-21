namespace P04_Punctuation_Finder
{
    using System.IO;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("Input.txt");

            var result = new List<string>();

            foreach (string line in text)
            {
               var letters = line.ToCharArray();

                foreach (var letter in letters)
                {
                    if (letter == '.' || letter == ',' || 
                        letter == '!' || letter == '?' || 
                        letter == ':')
                    {
                        result.Add($"{letter}");
                    }
                }
            }

            File.WriteAllText("Output.txt", string.Join(", ", result));
        }
    }
}