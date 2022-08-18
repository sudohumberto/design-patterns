
/// <summary>
/// Constructs and assembles parts of the product by implementing the Builder interface
/// Defines and keeps track of the representation it creates 
/// Provides an interface for retrieving the product
/// </summary>
class MakiBuilder : ISushiBuilder
{
    private Sushi _sushi = new();

    public void Reset() 
    {
        _sushi.Reset();
    }

    public void BuildRice()
    {
        _sushi.Add("Rice");
    }

    public void BuildNori()
    {
        _sushi.Add("Nori (Outside)");
    }

    public void BuildFish(string fish)
    {
        _sushi.Add(fish);
    }

    public void BuildVeggie(string veggie)
    {
        _sushi.Add(veggie);
    }

    public void BuildSauce(string sauce)
    {
        _sushi.Add(sauce);
    }

    public Sushi GetRoll()
    {
        return _sushi;
    }
}