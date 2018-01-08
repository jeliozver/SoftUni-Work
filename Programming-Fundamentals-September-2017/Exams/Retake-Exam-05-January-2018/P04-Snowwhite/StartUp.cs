namespace P04_Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string data = Console.ReadLine();

            var dwarfsData = new Dictionary<string, int>();

            while (data != "Once upon a time")
            {
                string[] args = data
                    .Split(new[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string dwarfName = args[0];
                string dwarfHatColor = args[1];
                int dwarfPhysics = int.Parse(args[2]);

                string nameHatColor = dwarfName + " " + dwarfHatColor;

                if (!dwarfsData.ContainsKey(nameHatColor))
                {
                    dwarfsData[nameHatColor] = dwarfPhysics;
                }
                else
                {
                    int oldPsysics = dwarfsData[nameHatColor];

                    if (dwarfPhysics > oldPsysics)
                    {
                        dwarfsData[nameHatColor] = dwarfPhysics;
                    }
                }

                data = Console.ReadLine();
            }

            foreach (var dwarf in dwarfsData
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfsData
                    .Count(y => y.Key.Split(' ')[1] == x.Key.Split(' ')[1])))
            {
                string[] args = dwarf.Key.Split(' ');

                string name = args[0];
                string hatColor = args[1];
                int psysics = dwarf.Value;

                Console.WriteLine($"({hatColor}) {name} <-> {psysics}");
            }
        }
    }
}