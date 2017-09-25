using System;

namespace Numbers_Ending_in_7
{
    class numsEndIn7
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
