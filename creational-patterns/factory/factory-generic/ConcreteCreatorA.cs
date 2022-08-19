
/// <summary>
/// Overrides the factory method to return an instance of a ConcreteProduct.
/// </summary>
class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}