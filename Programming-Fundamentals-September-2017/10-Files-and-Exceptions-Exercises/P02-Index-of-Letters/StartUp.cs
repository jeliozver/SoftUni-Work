namespace P02_Index_of_Letters
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string text = "Input.txt";

            char[] input = File.ReadAllText(text)
                .ToCharArray();

            var result = input
                .Select(letter => $"{letter} -> {letter - 'a'}")
                .ToList();

            File.WriteAllLines("Output.txt", result);
        }
    }
}