
/// <summary>
/// Represents the complex object under construction. 
/// ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
/// 
/// Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result
/// </summary>
class Product
{
    private List<string> _parts = new List<string>();

    public void Reset()
    {
        _parts.Clear();
    }

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("\nProduct Parts -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
    }
}