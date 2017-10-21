namespace P05_Write_to_File
{
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            var result = new List<string>();
            foreach (var line in input)
            {
                string currentLine = line.Replace(",", "");
                currentLine = currentLine.Replace(".", "");
                currentLine = currentLine.Replace("?", "");
                currentLine = currentLine.Replace("!", "");
                currentLine = currentLine.Replace(":", "");

                result.Add(currentLine);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}