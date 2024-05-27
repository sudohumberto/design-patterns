// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Adapter!");

Dollar dollar = new Dollar(100);
Currency euroAdapter = new EuroAdapter(dollar);
Console.WriteLine("Monto en euros: " + euroAdapter.getAmount());
