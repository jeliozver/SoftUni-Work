using System;

namespace Nums_1_to_N_With_Step_3
{
    class numsOne2NStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i +=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
