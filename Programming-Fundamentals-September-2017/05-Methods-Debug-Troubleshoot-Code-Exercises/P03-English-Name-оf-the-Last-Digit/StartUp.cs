namespace P03_English_Name_оf_the_Last_Digit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetEnglishNameOfLastDigit(number));
        }

        public static string GetEnglishNameOfLastDigit(long number)
        {
            string[] zeroToNine = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string lastDigitEnglish = string.Empty;
            long lastDigit = Math.Abs(number % 10);

            lastDigitEnglish = zeroToNine[lastDigit];
            return lastDigitEnglish;
        }
    }
}