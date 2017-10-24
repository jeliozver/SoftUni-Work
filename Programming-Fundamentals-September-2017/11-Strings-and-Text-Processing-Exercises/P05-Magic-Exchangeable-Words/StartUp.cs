namespace P05_Magic_Exchangeable_Words
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            string wordOne = input[0];
            string wordTwo = input[1];

            Console.WriteLine(IsWordsExchangeable(wordOne, wordTwo) 
                ? "true" 
                : "false");
        }

        public static bool IsWordsExchangeable(string wordOne, string wordTwo)
        {
            wordOne = new String(wordOne.Distinct().ToArray());
            wordTwo = new String(wordTwo.Distinct().ToArray());

            return wordOne.Length == wordTwo.Length;
        }
    }
}