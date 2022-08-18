
/// <summary>
/// Implements the operations to create concrete product objects 
/// with the style of Factory 2
/// </summary>
public class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}