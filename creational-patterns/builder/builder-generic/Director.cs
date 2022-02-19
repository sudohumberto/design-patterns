
/// <summary>
/// Constructs an object using the Builder interface
/// The director knows which building steps to execute to get a working product.
/// </summary>
class Director
{
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}