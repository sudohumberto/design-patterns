
Console.WriteLine("Hello Prototype in Real World!");

Person p1 = new() {Name = "Jack Daniels", BirthDate=new DateTime(1977,01,01), Country = "USA", IdInfo = new IdInfo(1234)};

// Perform a shallow copy of p1 and assign it to p2.

Person p2 = p1.Clone();

// Make a deep copy of p1 and assign it to p3.

Person p3 = p1.DeepCopy();

// Display original values of p1, p2 and p3.

Console.WriteLine("Original values of p1, p2, p3:");

Console.WriteLine("p1 instance values: " + p1);
Console.WriteLine("p2 instance values: " + p2);
Console.WriteLine("p3 instance values: " + p3);

System.Console.WriteLine();

// Change the value of p1 properties and display the values of p1, p2 and p3.

p1.Name = "Jameson";
p1.BirthDate = Convert.ToDateTime("1780-01-01");
p1.Country = "Ireland";
p1.IdInfo.IdNumber = 6789;

Console.WriteLine("Values of p1, p2 and p3 after changes to p1:");
Console.WriteLine("p1 instance values: " + p1);
Console.WriteLine("p2 instance values: " + p2);
Console.WriteLine("p3 instance values: " + p3);