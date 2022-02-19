
/// <summary>
/// Director
/// The director knows which building steps to execute to get a working product.
/// </summary>
class Director
{
    public Director(Builder builder)
    {
        builder.BuildFrame();
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
    }
}