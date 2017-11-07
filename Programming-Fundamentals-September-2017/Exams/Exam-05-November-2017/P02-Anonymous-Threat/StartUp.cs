namespace P02_Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] args = command.Split(' ')
                    .ToArray();

                string action = args[0];

                if (action == "merge")
                {
                    int startIndex = int.Parse(args[1]);
                    int endIndex = int.Parse(args[2]);

                    if (startIndex < 0 || startIndex > words.Count - 1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }

                    if (endIndex > words.Count - 1)
                    {
                        endIndex = words.Count - 1;
                    }

                    var builder = new StringBuilder();
                    int count = 0;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        builder.Append(words[i]);
                        count++;
                    }

                    words.Insert(startIndex, builder.ToString());
                    words.RemoveRange(startIndex + 1, count);
                }
                else if (action == "divide")
                {
                    int index = int.Parse(args[1]);
                    int partititions = int.Parse(args[2]);

                    string itemToDivide = words[index];
                    int parts = itemToDivide.Length / partititions;

                    var divided = Divide(itemToDivide, parts).ToList();

                    if (itemToDivide.Length % partititions != 0)
                    {
                        var result = new List<string>();

                        for (int i = 0; i < divided.Count - 2; i++)
                        {
                            result.Add(divided[i]);
                        }

                        string partOne = divided[divided.Count - 2];
                        string partTwo = divided[divided.Count - 1];
                        string combine = partOne + partTwo;

                        result.Add(combine);

                        divided = result;
                    }

                    int indexToInsert = index;

                    if (index == words.Count)
                    {
                        indexToInsert--;
                    }

                    words.RemoveAt(index);
                    words.InsertRange(indexToInsert, divided);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", words));
        }

        public static List<string> Divide(string str, int parts)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < str.Length; i += parts)
            {
                result.Add(str.Length - i >= parts
                    ? str.Substring(i, parts)
                    : str.Substring(i, str.Length - i));
            }

            return result;
        }
    }
}