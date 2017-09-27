using System;

namespace SMS_Typing
{
    class SmsTyping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string smsResult = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string message = Console.ReadLine();

                int numberOfDigits = message.Length;
                int mainDigit = message[0] - 48;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + numberOfDigits - 1) + 97;

                if (letterIndex == 91)
                {
                    letterIndex = 32;
                }

                char convertToText = Convert.ToChar(letterIndex);
                smsResult += "" + convertToText;
            }

            Console.WriteLine(smsResult);
        }
    }
}