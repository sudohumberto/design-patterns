
System.Console.WriteLine("Hello Abstract Factory in Real World!");

// Create and run the African animal world

AnimalsFactory africanFactory = new AfricaFactory();
Zoo africanZoo = new Zoo(africanFactory);
africanZoo.RunFoodChain();

// Create and run the American animal world

AnimalsFactory americanFactory = new AmericaFactory();
Zoo americanZoo = new Zoo(americanFactory);
americanZoo.RunFoodChain();