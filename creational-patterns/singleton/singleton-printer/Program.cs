// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Singleton in Real World!");


Printer firstPrinterObject = Printer.Instance();  
firstPrinterObject.AddDocument("Don Quixote.txt");


Printer secondPrinterObject = Printer.Instance();  
secondPrinterObject.AddDocument("Animal Farm.txt");


Printer thirdPrinterObject = Printer.Instance(); 
thirdPrinterObject.AddDocument("Dracula.txt");



System.Console.WriteLine($"firstPrinterObject Documents");
firstPrinterObject.PrintDocuments();


System.Console.WriteLine($"secondPrinterObject Documents");
secondPrinterObject.PrintDocuments();


System.Console.WriteLine($"thirdPrinterObject Documents");
thirdPrinterObject.PrintDocuments();
