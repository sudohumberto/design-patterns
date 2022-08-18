
/// <summary>
/// The 'Client' class 
/// </summary>
public class Zoo
{
    public Herbivore _herbivore;
    public Carnivore _carnivore;
    // Constructor
    public Zoo(AnimalsFactory factory)
    {
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}