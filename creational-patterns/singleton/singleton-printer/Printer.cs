
/// <summary>
/// Singleton
/// </summary>
public class Printer
{
    static Printer _instance = null!;

    static List<string> _queue = new();
    
    // Constructor is 'protected'
    protected Printer()
    {
        
    }

    public void AddDocument(string document) 
    {
        _queue.Add(document);
    }

    public void PrintDocuments() 
    {
        foreach (var document in _queue) 
        {
            System.Console.WriteLine(document);
        }
    }

    public static Printer Instance()
    {
        // Uses lazy initialization.
        // Note: this is not thread safe.
        if (_instance == null)
        {
            _instance = new Printer();
        }
        return _instance;
    }
}