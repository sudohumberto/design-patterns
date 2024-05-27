// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Adapter!");

Adaptee adaptee = new ();
Target adapter = new Adapter(adaptee);
adapter.Request();