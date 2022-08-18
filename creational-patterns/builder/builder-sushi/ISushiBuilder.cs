
/// <summary>
/// Specifies an abstract interface for creating parts of a Product object
/// Different builders execute the same task in various ways.
/// </summary>
interface ISushiBuilder
{
    public void Reset();
    public void BuildRice();
    public void BuildNori();
    public void BuildFish(string fish);
    public void BuildVeggie(string veggie);
    public void BuildSauce(string sauce);
    public Sushi GetRoll();
}