using System;

namespace BPM_Counter
{
    class BpmCounter
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int NumberOfBeats = int.Parse(Console.ReadLine());

            double bars = (double)NumberOfBeats / 4;
            double sequenceSeconds = Math.Floor(60 / (double)beatsPerMinute * NumberOfBeats);
            int sequenceMinutes = 0;

            while (sequenceSeconds >= 60)
            {
                sequenceMinutes++;
                sequenceSeconds -= 60;
            }

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {sequenceMinutes}m {sequenceSeconds}s");
        }
    }
}