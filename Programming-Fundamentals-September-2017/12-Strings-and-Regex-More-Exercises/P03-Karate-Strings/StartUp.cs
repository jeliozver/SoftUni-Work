namespace P03_Karate_Strings
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string karateString = Console.ReadLine();

            int punchPower = 0;
            var builder = new StringBuilder();

            for (int i = 0; i < karateString.Length; i++)
            {
                if (karateString[i] == '>')
                {
                    punchPower += int.Parse(karateString[i + 1].ToString());
                }
                else if (punchPower > 0)
                {
                    punchPower--;
                    continue;
                }

                builder.Append(karateString[i]);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}