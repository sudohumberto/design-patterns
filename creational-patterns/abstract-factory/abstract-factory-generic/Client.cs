
/// <summary>
/// Uses AbstractFactory and AbstractProduct
/// It does not have direct access to any Concrete Factory or product
/// </summary>
public class Client
{
    public AbstractProductA AbstractProductA { get; set; }
    public AbstractProductB AbstractProductB { get; set; }

    public Client(AbstractFactory factory)
    {
        AbstractProductB = factory.CreateProductB();
        AbstractProductA = factory.CreateProductA();
    }
}