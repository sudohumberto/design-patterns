/// <summary>
/// Target
/// Defines the domain-specific interface that Client uses.
/// </summary>
public class Compound
{
    protected float boilingPoint;
    protected float meltingPoint;
    protected double molecularWeight;
    protected string molecularFormula = null!;
    public virtual void Display()
    {
        Console.WriteLine("\nCompound: Unknown ------ ");
    }
}