
/// <summary>
/// Constructs and assembles parts of the product by implementing the Builder interface
/// Defines and keeps track of the representation it creates 
/// Provides an interface for retrieving the product
/// </summary>
class ConcreteBuilder1 : IBuilder
{
    private Product _product = new();

    public void Reset()
    {
        _product.Reset();
    }
    
    public void BuildPartA()
    {
        _product.Add("PartA1");
    }

    public void BuildPartB()
    {
        _product.Add("PartB1");
    }

    public void BuildPartC()
    {
        _product.Add("PartC1");
    }

    public Product GetProduct()
    {
        return _product;
    }
}