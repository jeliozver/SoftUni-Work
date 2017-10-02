namespace P13_Decrypting_Messages
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int decryptKey = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decryptedMessage = string.Empty;
            int decrypt = 0;

            for (int i = 1; i <= n; i++)
            {
                char encryptedChar = char.Parse(Console.ReadLine());
                decrypt = encryptedChar + decryptKey;
                char decryptedChar = Convert.ToChar(decrypt);
                decryptedMessage += "" + decryptedChar;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}