
/// <summary>
/// Implements the operations to create concrete product objects 
/// with the style of Factory 1
/// </summary>
public class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}