using System;

namespace Password_Guess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string attempt = Console.ReadLine();

            if (attempt == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
