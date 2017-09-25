using System;

namespace Christmas_Tree
{
    class christmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', i);

                Console.WriteLine($"{spaces}{stars} | {stars}{spaces}");
            }
        }
    }
}
