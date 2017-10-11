namespace P05_Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(new []
                { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] result = text
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}