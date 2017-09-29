using System;

namespace PB_July_2015_2_Detective_Boev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();

            string decryptedMessage = string.Empty;
            string decryptedReverse = string.Empty;

            int sum = 0;

            for (int i = 0; i < secretWord.Length; i++)
            {
                sum += secretWord[i];
            }

            int mask = 1 + (sum - 1) % 9;

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int decryptedLetterInt = 0;
                char decryptedLetterChar = 'a';

                if (encryptedMessage[i] % mask == 0)
                {
                    decryptedLetterInt += encryptedMessage[i] + mask;
                    decryptedLetterChar = Convert.ToChar(decryptedLetterInt);
                    decryptedMessage += decryptedLetterChar;
                }
                else
                {
                    decryptedLetterInt += encryptedMessage[i] - mask;
                    decryptedLetterChar = Convert.ToChar(decryptedLetterInt);
                    decryptedMessage += decryptedLetterChar;
                }
            }

            for (int i = decryptedMessage.Length; i > 0; i--)
            {
                decryptedReverse += decryptedMessage[i - 1];
            }

            Console.WriteLine(decryptedReverse);
        }
    }
}