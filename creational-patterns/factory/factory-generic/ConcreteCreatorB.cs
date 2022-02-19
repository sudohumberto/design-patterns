
/// <summary>
/// Overrides the factory method to return an instance of a ConcreteProduct.
/// </summary>
class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProductB();
    }
}