using System;

namespace Foreign_Languages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
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