namespace P02_Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string text = "Input.txt";
                string[] lines = File.ReadAllLines(text);
                var linesNumbers = new List<string>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string currentLine = $"{i + 1}.  {lines[i]}";
                    linesNumbers.Add(currentLine);
                }

                File.WriteAllLines("Output.txt", linesNumbers);
            }
            catch (Exception)
            {
                Console.WriteLine("Create Input.txt with test info");
                Console.ReadKey();
            }
        }
    }
}