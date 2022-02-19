
/// <summary>
/// Specifies an abstract interface for creating parts of a Product object
/// Different builders execute the same task in various ways.
/// </summary>
abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
}