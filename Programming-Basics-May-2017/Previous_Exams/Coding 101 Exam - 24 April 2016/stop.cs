using System;

namespace PB_April_2016_5_Stop
{
    class stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // static part
            int slashesC = 4;
            string slash = new string('/', slashesC / 2);
            int backslashesC = 4;
            string backslash = new string('\u005C', backslashesC / 2);

            // dynamic part
            int dotsC = (n *  2) + 2;
            string dot = new string('.', dotsC / 2);
            int underscoresC = (n * 2) + 1;
            string underscore = new string('_', underscoresC);
 
            // First line
            Console.WriteLine($"{dot}{underscore}{dot}");

            // Top
            dotsC = n;
            underscoresC = (n * 2) - 1;
            
            for (int i = 0; i < (n * 2) - n; i++)
            {
                dot = new string('.', dotsC);
                underscore = new string('_', underscoresC);

                Console.WriteLine($"{dot}{slash}{underscore}{backslash}{dot}");

                dotsC--;
                underscoresC += 2;
            }

            // Middle top
            underscoresC = underscoresC / 2 - 2;
            underscore = new string('_', underscoresC);
            Console.WriteLine($"{slash}{underscore}STOP!{underscore}{backslash}");

            // Middle bottom
            underscoresC = underscoresC * 2 + 5;
            underscore = new string('_', underscoresC);
            Console.WriteLine($"{backslash}{underscore}{slash}");

            // Bottom
            underscoresC = (n * 4) - 3;
            dotsC = 1;
            for (int i = 0; i < ((n * 2) - n) - 1; i++)
            {
                dot = new string('.', dotsC);
                underscore = new string('_', underscoresC);

                Console.WriteLine($"{dot}{backslash}{underscore}{slash}{dot}");

                dotsC++;
                underscoresC -= 2;
            }
        }
    }
}
