namespace P09_Reversed_Chars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());

            string lettersReversed = "" + letterThree  + letterTwo + letterOne;
            Console.WriteLine(lettersReversed);
        }
    }
}
    