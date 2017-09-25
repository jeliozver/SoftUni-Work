using System;

namespace Rhombus_of_Stars
{
    class rhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spaceCount = n - 1;
            int starSCount = 1;

            string space = newStr(" ", spaceCount);
            string spaceStar = newStr("* ", starSCount);

            for (int i = 1; i <= n; i++)
            {
                space = newStr(" ", spaceCount);
                spaceStar = newStr("* ", starSCount);

                Console.WriteLine($"{space}{spaceStar}");

                spaceCount--;
                starSCount++;
            }
			
            spaceCount = 1;
            starSCount = n - 1;

            for (int i = 0; i < n - 1; i++)
            {
                space = newStr(" ", spaceCount);
                spaceStar = newStr("* ", starSCount);
				
                Console.WriteLine($"{space}{spaceStar}");

                spaceCount++;
                starSCount--;
            }
        }

        private static string newStr(string str, int count)
        {
            string body = "";

            for (int i = 0; i < count; i++)
            {
                body = body + str;
            }
            return body;
        }
    }
}
