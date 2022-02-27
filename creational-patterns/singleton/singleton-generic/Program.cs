// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Singleton!");

// Constructor is protected -- cannot use new
Singleton s1 = Singleton.Instance();
Singleton s2 = Singleton.Instance();

// Test for same instance
if (s1 == s2)
{
    Console.WriteLine("Objects are the same instance");
}

s1.IntegerValue = 42;

System.Console.WriteLine($"s1.IntegerValue: {s1.IntegerValue}");
System.Console.WriteLine($"s2.IntegerValue: {s2.IntegerValue}");