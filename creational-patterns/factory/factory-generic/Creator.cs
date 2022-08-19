
/// <summary>
/// Declares the factory method, which returns an object of type Product. 
/// Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
/// 
/// May call the factory method to create a Product object.
/// </summary>
abstract class Creator
{
    public abstract IProduct FactoryMethod();
}