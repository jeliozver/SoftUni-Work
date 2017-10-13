namespace P08_Logs_Aggregator
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int logsCount = int.Parse(Console.ReadLine());

            var usersLog = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= logsCount; i++)
            {
                string currentLog = Console.ReadLine();
                string[] arguments = currentLog.Split(' ');

                string currentIp = arguments[0];
                string currentUser = arguments[1];
                int currentDuration = int.Parse(arguments[2]);

                if (!usersLog.ContainsKey(currentUser))
                {
                    usersLog[currentUser] = new SortedDictionary<string, int>();
                }

                if (!usersLog[currentUser].ContainsKey(currentIp))
                {
                    usersLog[currentUser].Add(currentIp, 0);
                }

                usersLog[currentUser][currentIp] += currentDuration;
            }

            foreach (var user in usersLog)
            {
                List<string> result = new List<string>();

                int sumDurations = 0;

                Console.Write($"{user.Key}: ");

                foreach (var ip in usersLog[user.Key])
                {
                    sumDurations += ip.Value;
                    result.Add($"{ip.Key}");
                }

                Console.WriteLine($"{sumDurations} [{string.Join(", ", result)}]");
            }
        }
    }
}