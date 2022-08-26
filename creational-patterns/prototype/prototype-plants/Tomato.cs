
/// <summary>
/// ConcretePrototype
/// Implements an operation for cloning itself
/// </summary>
public class Tomato : Plant
{
    public double Fruits { get; }
    public double Height { get; }
    
    public Tomato() 
    {
        Random rnd = new();
        Fruits = rnd.NextDouble()*100;
        Height = rnd.NextDouble()*10;
    }

    public override Plant Clone()
    {
        return (Plant)this.MemberwiseClone();
    }
}