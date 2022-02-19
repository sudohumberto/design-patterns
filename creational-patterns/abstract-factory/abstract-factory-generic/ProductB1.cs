
/// <summary>
/// Defines a product object to be created by the corresponding concrete factory (factory 1)
/// Implements the AbstractProduct interface
/// </summary>
class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(this.GetType().Name +
            " interacts with " + a.GetType().Name);
    }
}