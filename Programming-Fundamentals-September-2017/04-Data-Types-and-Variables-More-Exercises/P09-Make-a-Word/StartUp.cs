namespace P09_Make_a_Word
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte interval = byte.Parse(Console.ReadLine());

            string word = string.Empty;

            for (byte i = 1; i <= interval; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());
                word += "" + currentLetter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}