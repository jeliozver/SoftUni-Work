using System.Linq;

namespace P09_Legendary_Farming
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            bool isLegendaryItem = false;
            string legendaryItem = string.Empty;

            var keyMaterials = new Dictionary<string, int>();
            {
                keyMaterials["fragments"] = 0;
                keyMaterials["shards"] = 0;
                keyMaterials["motes"] = 0;
            };

            var junkMaterials = new SortedDictionary<string, int>();

            while (!isLegendaryItem)
            {
                string[] materials = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }

                    foreach (var mat in keyMaterials)
                    {
                        if (mat.Key == "shards" && mat.Value >= 250)
                        {
                            legendaryItem = "Shadowmourne obtained!";
                            keyMaterials[material] -= 250;
                            isLegendaryItem = true;
                            break;
                        }
                        else if (mat.Key == "fragments" && mat.Value >= 250)
                        {
                            legendaryItem = "Valanyr obtained!";
                            keyMaterials[material] -= 250;
                            isLegendaryItem = true;
                            break;
                        }
                        else if (mat.Key == "motes" && mat.Value >= 250)
                        {
                            legendaryItem = "Dragonwrath obtained!";
                            keyMaterials[material] -= 250;
                            isLegendaryItem = true;
                            break;
                        }
                    }

                    if (isLegendaryItem)
                    {
                        break;
                    }
                }
            }

            var keyMaterialssSorted = keyMaterials.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            Console.WriteLine(legendaryItem);

            foreach (var keyMaterial in keyMaterialssSorted)
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }

            foreach (var junk in junkMaterials)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}