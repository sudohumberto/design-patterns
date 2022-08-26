
Tomato tomatoPlant1 = new();

if (tomatoPlant1.Fruits > 30) 
{
    // Very Productive plant, we need to clone it!
    System.Console.WriteLine($"tomatoPlant1 Fruits: {tomatoPlant1.Fruits}");
    Plant tomatoPlant2 = tomatoPlant1.Clone();

    System.Console.WriteLine($"tomatoPlant2 Fruits: {((Tomato)tomatoPlant2).Fruits}");
}


Orchid orchidPlant1 = new();

if (orchidPlant1.Color == "black") 
{
    // Extremely rare plant, we need to clone it!
    Plant orchidPlant2 = orchidPlant1.Clone();

    System.Console.WriteLine($"orchidPlant2 Color: {((Orchid)orchidPlant2).Color}");
}