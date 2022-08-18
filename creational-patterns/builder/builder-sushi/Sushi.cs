
public class Sushi
{
    private List<string> _ingredients = new();

    public void Reset()
    {
        _ingredients.Clear();
    }

    public void Add(string ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public void Show()
    {
        Console.WriteLine("\nSushi Ingredients -------");
        foreach (string ingredient in _ingredients)
            Console.WriteLine(ingredient);
    }
}