
System.Console.WriteLine("Hello Abstract Factory in Real World!");

// Create and run the African animal world

AnimalFactory africa = new AfricaFactory();
AnimalWorld world = new AnimalWorld(africa);
world.RunFoodChain();

// Create and run the American animal world

AnimalFactory america = new AmericaFactory();
world = new AnimalWorld(america);
world.RunFoodChain();