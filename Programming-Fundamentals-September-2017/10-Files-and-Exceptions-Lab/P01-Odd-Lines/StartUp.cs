namespace P01_Odd_Lines
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
                var text = "Input.txt";
                var lines = File.ReadAllLines(text);
                var oddLines = new List<string>();

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddLines.Add(lines[i]);
                    }
                }

                File.WriteAllLines("Output.txt", oddLines);
            }
            catch (Exception)
            {
                Console.WriteLine("Create Input.txt with test info");
                Console.ReadKey();
            }
        }
    }
}