using System;

namespace String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string strToRepeat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NewString(strToRepeat, n));
        }

        static string NewString(string str, int count)
        {
            string body = string.Empty;

            for (int i = 0; i < count; i++)
            {
                body = body + str;
            }
            return body;
        }
    }
}