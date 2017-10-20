namespace P06_Fix_Emails
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = "Input.txt";

            var inputLines = File.ReadAllLines(input)
                .ToArray();
            int lastIndex = 0;

            string name = inputLines[lastIndex++];

            var nameEmail = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = inputLines[lastIndex++];

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    nameEmail[name] = email;
                }

                name = inputLines[lastIndex++];
            }

            var result = nameEmail
                .Select(item => $"{item.Key} -> {item.Value}")
                .ToList();

            File.WriteAllLines("Output.txt", result);
        }
    }
}