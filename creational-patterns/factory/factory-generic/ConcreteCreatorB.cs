
/// <summary>
/// Overrides the factory method to return an instance of a ConcreteProduct.
/// </summary>
class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}