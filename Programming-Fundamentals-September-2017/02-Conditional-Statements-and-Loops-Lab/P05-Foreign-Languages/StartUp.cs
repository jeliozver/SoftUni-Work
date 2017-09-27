namespace P05_Foreign_Languages
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string country = Console.ReadLine().ToLower();
            string language = String.Empty;

            if (country == "usa" || country == "england")
            {
                language = "English";
            }
            else if (country == "spain" || country == "argentina" || country == "mexico")
            {
                language = "Spanish";
            }
            else
            {
                language = "unknown";
            }

            Console.WriteLine(language);
        }
    }
}
