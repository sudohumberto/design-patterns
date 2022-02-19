// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Factory in Real World!");

Document[] documents = new Document[2];

documents[0] = new Resume();

documents[1] = new Report();

// Display document pages

foreach (Document document in documents)
{
    Console.WriteLine("\n" + document.GetType().Name + "--");
    foreach (Page page in document.Pages)
    {
        Console.WriteLine(" " + page.GetType().Name);
    }
}
