namespace P06_DNA_Sequences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int matchSum = int.Parse(Console.ReadLine());

            int sequences = 0;

            for (char i = 'A'; i <= 'T'; i++)
            {
                for (char j = 'A'; j <= 'T'; j++)
                {
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        char nucleotideOne = 'a';
                        char nucleotideTwo = 'a';
                        char nucleotideThree = 'a';

                        int nucletides = 0;

                        if (sequences == 4)
                        {
                            Console.WriteLine();
                            sequences = 0;
                        }

                        switch (i)
                        {
                            case 'A': nucletides += 1; nucleotideOne = 'A'; break;
                            case 'C': nucletides += 2; nucleotideOne = 'C'; break;
                            case 'G': nucletides += 3; nucleotideOne = 'G'; break;
                            case 'T': nucletides += 4; nucleotideOne = 'T'; break;
                        }
                        switch (j)
                        {
                            case 'A': nucletides += 1; nucleotideTwo = 'A'; break;
                            case 'C': nucletides += 2; nucleotideTwo = 'C'; break;
                            case 'G': nucletides += 3; nucleotideTwo = 'G'; break;
                            case 'T': nucletides += 4; nucleotideTwo = 'T'; break;
                        }
                        switch (k)
                        {
                            case 'A': nucletides += 1; nucleotideThree = 'A'; break;
                            case 'C': nucletides += 2; nucleotideThree = 'C'; break;
                            case 'G': nucletides += 3; nucleotideThree = 'G'; break;
                            case 'T': nucletides += 4; nucleotideThree = 'T'; break;
                        }

                        if (nucleotideOne != 'a' && nucleotideTwo != 'a' && nucleotideThree != 'a')
                        {
                            if (nucletides >= matchSum)
                            {
                                Console.Write($"O{nucleotideOne}{nucleotideTwo}{nucleotideThree}O ");
                                sequences++;
                            }
                            else
                            {
                                Console.Write($"X{nucleotideOne}{nucleotideTwo}{nucleotideThree}X ");
                                sequences++;
                            }
                        }
                    }
                }
            }
        }
    }
}
