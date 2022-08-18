
/// <summary>
/// Constructs and assembles parts of the product by implementing the Builder interface
/// Defines and keeps track of the representation it creates 
/// Provides an interface for retrieving the product
/// </summary>
class ConcreteBuilder2 : IBuilder
{
    private Product _product = new();

    public void Reset()
    {
        _product.Reset();
    }

    public void BuildPartA()
    {
        _product.Add("PartA2");
    }

    public void BuildPartB()
    {
        _product.Add("PartB2");
    }

    public void BuildPartC()
    {
        _product.Add("PartC2");
    }

    public Product GetProduct()
    {
        return _product;
    }
}