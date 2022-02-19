
/// <summary>
/// Builder
/// Different builders execute the same task in various ways.
/// </summary>
abstract class Builder
{

    protected Vehicle vehicle = null!;

    public Vehicle Vehicle
    {
        get { return vehicle; }
    }

    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
    
}