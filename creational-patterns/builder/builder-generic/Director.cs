
/// <summary>
/// Constructs an object using the Builder interface
/// The director knows which building steps to execute to get a working product.
/// </summary>
class Director
{
    // Builder uses a complex series of steps
    public Product BuildProductABC(IBuilder builder)
    {
        builder.Reset();
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
        return builder.GetProduct();
    }

    // Builder uses a complex series of steps
    public Product BuildProductB(IBuilder builder)
    {
        builder.Reset();
        builder.BuildPartB();
        return builder.GetProduct();
    }
}