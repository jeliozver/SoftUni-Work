namespace P04_Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            var nameEmail = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    nameEmail[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var item in nameEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}