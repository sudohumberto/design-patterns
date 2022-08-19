// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Bakery> bakeries = new() 
{
    new GermanBakery(),
    new FrenchBakery()
};

foreach (Bakery bakery in bakeries) 
{
    Bread bread = bakery.CreateBread();
    Console.WriteLine(bread.Fill("ham & cheese"));
}