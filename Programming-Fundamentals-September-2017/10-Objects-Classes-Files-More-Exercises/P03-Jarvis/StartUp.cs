namespace P03_Jarvis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var armOne = new Arm();
            var armTwo = new Arm();
            var legOne = new Leg();
            var legTwo = new Leg();
            var head = new Head();
            var torso = new Torso();

            head.Energy = long.MaxValue;
            torso.Energy = long.MaxValue;

            bool isHeadTaken = false;
            bool isTorsoTaken = false;
            bool isArmOneTaken = false;
            bool isArmTwoTaken = false;
            bool isLegOneTaken = false;
            bool isLegTwoTaken = false;

            long maxEnergy = long.Parse(Console.ReadLine());

            string currentComponents = Console.ReadLine();

            while (currentComponents != "Assemble!")
            {
                string[] arguments = currentComponents
                    .Split(' ')
                    .ToArray();

                long currentEnergy = long.Parse(arguments[1]);

                if (arguments[0] == "Arm")
                {
                    if (armOne.Energy > currentEnergy
                        && armTwo.Energy > currentEnergy
                        && isArmOneTaken && isArmTwoTaken)
                    {
                        armOne.Energy = armTwo.Energy;
                        armOne.Reach = armTwo.Reach;
                        armOne.Fingers = armTwo.Fingers;

                        armTwo.Energy = currentEnergy;
                        armTwo.Reach = int.Parse(arguments[2]);
                        armTwo.Fingers = int.Parse(arguments[3]);
                    }
                    else if (!isArmOneTaken)
                    {
                        armOne.Energy = currentEnergy;
                        armOne.Reach = int.Parse(arguments[2]);
                        armOne.Fingers = int.Parse(arguments[3]);
                        isArmOneTaken = true;
                    }
                    else if (!isArmTwoTaken)
                    {
                        armTwo.Energy = currentEnergy;
                        armTwo.Reach = int.Parse(arguments[2]);
                        armTwo.Fingers = int.Parse(arguments[3]);
                        isArmTwoTaken = true;
                    }
                    else if (armOne.Energy > currentEnergy)
                    {
                        armOne.Energy = currentEnergy;
                        armOne.Reach = int.Parse(arguments[2]);
                        armOne.Fingers = int.Parse(arguments[3]);
                    }
                    else if (armTwo.Energy > currentEnergy)
                    {
                        armTwo.Energy = currentEnergy;
                        armTwo.Reach = int.Parse(arguments[2]);
                        armTwo.Fingers = int.Parse(arguments[3]);
                    }
                }
                else if (arguments[0] == "Leg")
                {
                    if (legOne.Energy > currentEnergy
                        && legTwo.Energy > currentEnergy
                        && isLegOneTaken && isLegTwoTaken)
                    {
                        legOne.Energy = legTwo.Energy;
                        legOne.Strength = legTwo.Strength;
                        legOne.Speed = legTwo.Speed;

                        legTwo.Energy = currentEnergy;
                        legTwo.Strength = int.Parse(arguments[2]);
                        legTwo.Speed = int.Parse(arguments[3]);
                    }
                    else if (!isLegOneTaken)
                    {
                        legOne.Energy = currentEnergy;
                        legOne.Strength = int.Parse(arguments[2]);
                        legOne.Speed = int.Parse(arguments[3]);
                        isLegOneTaken = true;
                    }
                    else if (!isLegTwoTaken)
                    {
                        legTwo.Energy = currentEnergy;
                        legTwo.Strength = int.Parse(arguments[2]);
                        legTwo.Speed = int.Parse(arguments[3]);
                        isLegTwoTaken = true;
                    }
                    else if (legOne.Energy > currentEnergy)
                    {
                        legOne.Energy = currentEnergy;
                        legOne.Strength = int.Parse(arguments[2]);
                        legOne.Speed = int.Parse(arguments[3]);
                    }
                    else if (legTwo.Energy > currentEnergy)
                    {
                        legTwo.Energy = currentEnergy;
                        legTwo.Strength = int.Parse(arguments[2]);
                        legTwo.Speed = int.Parse(arguments[3]);
                    }
                }
                else if (arguments[0] == "Torso")
                {
                    if (torso.Energy > currentEnergy)
                    {
                        torso.Energy = currentEnergy;
                        torso.CpuSize = double.Parse(arguments[2]);
                        torso.Material = arguments[3];
                        isTorsoTaken = true;
                    }
                }
                else if (arguments[0] == "Head")
                {
                    if (head.Energy > currentEnergy)
                    {
                        head.Energy = currentEnergy;
                        head.Iq = int.Parse(arguments[2]);
                        head.Material = arguments[3];
                        isHeadTaken = true;
                    }
                }

                currentComponents = Console.ReadLine();
            }

            long enegryRequired = head.Energy + torso.Energy +
                armOne.Energy + armTwo.Energy
                + legOne.Energy + legTwo.Energy;

            bool isEnoughParts = isArmOneTaken && isArmTwoTaken
                && isLegOneTaken && isLegTwoTaken
                && isTorsoTaken && isHeadTaken;

            if (enegryRequired > maxEnergy)
            {
                Console.WriteLine("We need more power!");
            }
            else if (!isEnoughParts)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                var arms = new List<Arm> { armOne, armTwo }.OrderBy(e => e.Energy);
                var legs = new List<Leg> { legOne, legTwo }.OrderBy(e => e.Energy);

                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine($"###Energy consumption: {head.Energy}");
                Console.WriteLine($"###IQ: {head.Iq}");
                Console.WriteLine($"###Skin material: {head.Material}");

                Console.WriteLine("#Torso:");
                Console.WriteLine($"###Energy consumption: {torso.Energy}");
                Console.WriteLine($"###Processor size: {torso.CpuSize:f1}");
                Console.WriteLine($"###Corpus material: {torso.Material}");

                foreach (var arm in arms)
                {
                    Console.WriteLine("#Arm:");
                    Console.WriteLine($"###Energy consumption: {arm.Energy}");
                    Console.WriteLine($"###Reach: {arm.Reach}");
                    Console.WriteLine($"###Fingers: {arm.Fingers}");
                }

                foreach (var leg in legs)
                {
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {leg.Energy}");
                    Console.WriteLine($"###Strength: {leg.Strength}");
                    Console.WriteLine($"###Speed: {leg.Speed}");
                }
            }
        }
    }
}