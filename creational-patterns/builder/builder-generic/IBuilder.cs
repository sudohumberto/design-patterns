
/// <summary>
/// Specifies an abstract interface for creating parts of a Product object
/// Different builders execute the same task in various ways.
/// </summary>
interface IBuilder
{
    public void Reset();
    public void BuildPartA();
    public void BuildPartB();
    public void BuildPartC();
    public Product GetProduct();
}