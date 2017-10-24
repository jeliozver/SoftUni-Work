namespace P09_Melrah_Shake
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string randomChars = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = randomChars.IndexOf(pattern);
                int lastIndex = randomChars.LastIndexOf(pattern);

                if (firstIndex != -1 && lastIndex != -1 && pattern != string.Empty)
                {
                    Console.WriteLine("Shaked it.");

                    var builder = new StringBuilder();
                    builder.Append(randomChars);
                    builder.Remove(firstIndex, pattern.Length);
                    lastIndex -= pattern.Length;
                    builder.Remove(lastIndex, pattern.Length);
                    randomChars = builder.ToString();
                    int patternRemoveIndex = pattern.Length / 2;
                    builder = new StringBuilder();
                    builder.Append(pattern);
                    builder.Remove(patternRemoveIndex, 1);
                    pattern = builder.ToString();
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);
                    break;
                }
            }
        }
    }
}