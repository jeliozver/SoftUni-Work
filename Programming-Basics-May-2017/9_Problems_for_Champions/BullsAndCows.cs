using System;

namespace Bulls_and_Cows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            int secretNum = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            bool isPrinted = false;

            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            int guessDigit1 = (secretNum / 1000) % 10;
                            int guessDigit2 = (secretNum / 100) % 10;
                            int guessDigit3 = (secretNum / 10) % 10;
                            int guessDigit4 = (secretNum / 1) % 10;

                            int digitToCheck1 = d1;
                            int digitToCheck2 = d2;
                            int digitToCheck3 = d3;
                            int digitToCheck4 = d4;

                            int currentBulls = 0;
                            int currentCows = 0;

                            // Bulls checks start
                            if (digitToCheck1 == guessDigit1)
                            {
                                currentBulls++;
                                guessDigit1 = -1;
                                digitToCheck1 = -2;
                            }
                            if (digitToCheck2 == guessDigit2)
                            {
                                currentBulls++;
                                guessDigit2 = -1;
                                digitToCheck2 = -2;
                            }
                            if (digitToCheck3 == guessDigit3)
                            {
                                currentBulls++;
                                guessDigit3 = -1;
                                digitToCheck3 = -2;
                            }
                            if (digitToCheck4 == guessDigit4)
                            {
                                currentBulls++;
                                guessDigit4 = -1;
                                digitToCheck4 = -2;
                            }
                            // Bulls checks end

                            // Cows checks start
                            if (digitToCheck1 == guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if (digitToCheck1 == guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            else if (digitToCheck1 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }

                            if (digitToCheck2 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck2 == guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            else if (digitToCheck2 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }

                            if (digitToCheck3 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck3 == guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if (digitToCheck3 == guessDigit4)
                            {
                                currentCows++;
                                guessDigit4 = -1;
                            }

                            if (digitToCheck4 == guessDigit1)
                            {
                                currentCows++;
                                guessDigit1 = -1;
                            }
                            else if (digitToCheck4 == guessDigit2)
                            {
                                currentCows++;
                                guessDigit2 = -1;
                            }
                            else if (digitToCheck4 == guessDigit3)
                            {
                                currentCows++;
                                guessDigit3 = -1;
                            }
                            // Cows checks end

                            if (currentBulls == bulls && currentCows == cows)
                            {
                                isPrinted = true;
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }
            }

            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}