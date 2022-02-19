
/// <summary>
/// Product B1
/// Defines an animal object to be created by the corresponding concrete factory (AfricaFactory)
/// Implements the AbstractProduct (Carnivore) interface
/// </summary>
class Lion : Carnivore
{
    public override void Eat(Herbivore h)
    {
        // Eat Giraffe
        Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
    }
}