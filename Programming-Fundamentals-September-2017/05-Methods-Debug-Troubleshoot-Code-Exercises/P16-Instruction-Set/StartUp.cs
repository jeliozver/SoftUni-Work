namespace P16_Instruction_Set
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string opCode = Console.ReadLine();

            InstructionSet(opCode);
        }

        public static void InstructionSet(string opCode)
        {
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                long operandOne = long.Parse(codeArgs[1]);

                switch (codeArgs[0])
                {
                    case "INC":
                        result = ++operandOne;
                        break;

                    case "DEC":
                        result = --operandOne;
                        break;

                    case "ADD":
                        {
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}