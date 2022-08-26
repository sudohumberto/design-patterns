
/// <summary>
/// ConcretePrototype
/// </summary>
public class Orchid : Plant
{
    public string Color { get;  } = null!;
    public double Flowers { get; }

    public Orchid() 
    {
        Random rnd = new();
        string[] colors = {"white", "purple", "black", "red", "yellow"};

        Color = colors[rnd.Next(0,colors.Count())];
        Flowers = rnd.NextDouble()*20;
    }

    public override Plant Clone()
    {
        return (Plant)this.MemberwiseClone();
    }
}