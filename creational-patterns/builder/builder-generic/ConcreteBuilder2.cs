
/// <summary>
/// Constructs and assembles parts of the product by implementing the Builder interface
/// Defines and keeps track of the representation it creates 
/// Provides an interface for retrieving the product
/// </summary>
class ConcreteBuilder2 : Builder
{
    private Product _product = new Product();
    public override void BuildPartA()
    {
        _product.Add("PartX");
    }
    public override void BuildPartB()
    {
        _product.Add("PartY");
    }
    public override Product GetResult()
    {
        return _product;
    }
}