namespace P02_Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> listsTpAppend = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> appendedList = new List<int>();

            for (int i = listsTpAppend.Count; i > 0; i--)
            {
                int[] temp = listsTpAppend[i - 1]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int element in temp)
                {
                    appendedList.Insert(appendedList.Count, element);
                }
            }

            Console.WriteLine(string.Join(" ", appendedList));
        }
    }
}