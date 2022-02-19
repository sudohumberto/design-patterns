
System.Console.WriteLine("Hello Abstract Factory!");

// Abstract factory #1 (client1 can create ProductA1 and ProductB1)

AbstractFactory factory1 = new ConcreteFactory1();
Client client1 = new Client(factory1);
client1.Run();

// Abstract factory #2 (client2 can create ProductA2 and ProductB2)

AbstractFactory factory2 = new ConcreteFactory2();
Client client2 = new Client(factory2);
client2.Run();
