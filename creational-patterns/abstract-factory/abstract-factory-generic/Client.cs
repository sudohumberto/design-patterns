
/// <summary>
/// Uses interfaces declared by AbstractFactory and AbstractProduct classes
/// It does not have access to any Concrete Factory nor product
/// </summary>
class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;
    // Constructor
    public Client(AbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }
    public void Run()
    {
        _abstractProductB.Interact(_abstractProductA);
    }
}