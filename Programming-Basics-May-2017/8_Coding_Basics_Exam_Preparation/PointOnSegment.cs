using System;

namespace Point_on_Segment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            int firstEnd = int.Parse(Console.ReadLine());
            int secondEnd = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int distance1 = Math.Abs(firstEnd - point);
            int distance2 = Math.Abs(secondEnd - point);
            int nearEnd = 0;

            if (distance1 <= distance2)
            {
                nearEnd = distance1;
            }
            else
            {
                nearEnd = distance2;
            }

            if (firstEnd < secondEnd)
            {
                if (firstEnd <= point && point <= secondEnd)
                {
                    Console.WriteLine("in");
                    Console.WriteLine("{0}", nearEnd);
                }
                else
                {
                    Console.WriteLine("out");
                    Console.WriteLine("{0}", nearEnd);
                }
            }

            else if (firstEnd > secondEnd)
            {
                if (firstEnd >= point && point >= secondEnd)
                {
                    Console.WriteLine("in");
                    Console.WriteLine("{0}", nearEnd);
                }
                else
                {
                    Console.WriteLine("out");
                    Console.WriteLine("{0}", nearEnd);
                }
            }
        }
    }
}
