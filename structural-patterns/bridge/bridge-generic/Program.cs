// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Bridge!");

Abstraction abstraction;

abstraction = new Abstraction(new ConcreteImplementationA());

abstraction.Feature1();
abstraction.Feature2();
            
Console.WriteLine();

abstraction = new RefinedAbstraction(new ConcreteImplementationB());

abstraction.Feature1();
abstraction.Feature2();
((RefinedAbstraction) abstraction).FeatureN();
