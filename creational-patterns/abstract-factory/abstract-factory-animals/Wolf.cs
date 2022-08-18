
/// <summary>
/// Product B2
/// Defines an animal object to be created by the corresponding concrete factory (AmericaFactory)
/// Implements the AbstractProduct (Carnivore) interface
/// </summary>
public class Wolf : Carnivore
{
    public override void Eat(Herbivore h)
    {
        // Eat Bison
        Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
    }
}