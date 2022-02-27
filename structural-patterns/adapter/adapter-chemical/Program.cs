// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Adapter in Real World!");

// Non-adapted chemical compound

Compound unknown = new Compound();
unknown.Display();

// Adapted chemical compounds

Compound water = new RichCompound("Water");
water.Display();

Compound benzene = new RichCompound("Benzene");
benzene.Display();

Compound ethanol = new RichCompound("Ethanol");
ethanol.Display();