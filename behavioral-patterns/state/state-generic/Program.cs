// See https://aka.ms/new-console-template for more information
using state_generic;

Console.WriteLine("Hello, World!");

Context context = new(new ConcreteStateA());
context.Request1();
context.Request2();
