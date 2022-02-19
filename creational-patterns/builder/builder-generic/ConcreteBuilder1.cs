
/// <summary>
/// Constructs and assembles parts of the product by implementing the Builder interface
/// Defines and keeps track of the representation it creates 
/// Provides an interface for retrieving the product
/// </summary>
class ConcreteBuilder1 : Builder
{
    private Product _product = new Product();
    public override void BuildPartA()
    {
        _product.Add("PartA");
    }
    public override void BuildPartB()
    {
        _product.Add("PartB");
    }
    public override Product GetResult()
    {
        return _product;
    }
}