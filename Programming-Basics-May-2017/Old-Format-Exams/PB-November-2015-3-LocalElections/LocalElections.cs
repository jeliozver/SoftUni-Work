using System;

namespace PB_November_2015_3_LocalElections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int voteNum = int.Parse(Console.ReadLine());
            char votingSymbol = char.Parse(Console.ReadLine());

            int ballotWidth = 13;
            int ballot = 0;

            while (candidates > ballot)
            {
                ballot++;

                string ballotNum = "" + ballot;
                if (ballot < 10)
                {
                    ballotNum = 0 + "" + ballot;
                }

                bool isBallotVotedX = ballot == voteNum && votingSymbol == 'x' || 
                    ballot == voteNum && votingSymbol == 'X';

                bool isBallotVotedV = ballot == voteNum && votingSymbol == 'v' ||
                    ballot == voteNum && votingSymbol == 'V';

                // Ballot opening line
                Console.WriteLine("{0}", new string('.', ballotWidth));
                // Ballot line 1
                Console.WriteLine("...+-----+...");

                // Ballot line 2
                if (isBallotVotedV)
                {
                    Console.WriteLine("...|\\.../|...");
                }
                else if (isBallotVotedX)
                {
                    Console.WriteLine("...|.\\./.|...");
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                }

                // Ballot line 3
                if (isBallotVotedV)
                {
                    Console.WriteLine($"{ballotNum}.|.\\./.|...");
                }
                else if (isBallotVotedX)
                {
                    Console.WriteLine($"{ballotNum}.|..X..|...");
                }
                else
                {
                    Console.WriteLine($"{ballotNum}.|.....|...");
                }

                // Ballot line 4
                if (isBallotVotedV)
                {
                    Console.WriteLine("...|..V..|...");
                }
                else if (isBallotVotedX)
                {
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                }

                // Ballot line 5
                Console.WriteLine("...+-----+...");
            }

            // Closing line
            Console.WriteLine("{0}", new string('.', ballotWidth));
        }
    }
}