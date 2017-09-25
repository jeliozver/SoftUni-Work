using System;

namespace String_Encryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
  
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += Encrypt(letter);
            }

            Console.WriteLine(result);
        }

        static string Encrypt(char letter)
        {
            int firstDigit = 0;

            if (letter >= 'd' && letter <= 'z')
            {
                firstDigit = (letter / 100) % 10;
            }
            else
            {
                firstDigit = (letter / 10) % 10;
            }
            
            int lastDigit = (letter / 1) % 10;

            int leftSum = letter + lastDigit;
            char left = (char)leftSum;
            int rightSum = letter - firstDigit;
            char right = (char)rightSum;

            string result = $"{left}{firstDigit}{lastDigit}{right}";

            return result;
        }
    }
}