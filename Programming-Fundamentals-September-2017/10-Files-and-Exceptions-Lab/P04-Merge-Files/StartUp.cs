namespace P04_Merge_Files
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
                string fileOne = "FileOne.txt";
                string fileTwo = "FileTwo.txt";

                string[] linesOne = File.ReadAllLines(fileOne);
                string[] linesTwo = File.ReadAllLines(fileTwo);

                var result = new List<string>();

                for (int i = 0; i < linesOne.Length; i++)
                {
                    result.Add(linesOne[i]);
                    result.Add(linesTwo[i]);
                }

                File.WriteAllLines("Output.txt", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Create Input.txt with test info");
                Console.ReadKey();
            }
        }
    }
}