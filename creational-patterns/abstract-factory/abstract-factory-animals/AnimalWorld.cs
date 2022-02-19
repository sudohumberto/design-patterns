
/// <summary>
/// The 'Client' class 
/// </summary>
class AnimalWorld
{
    private Herbivore _herbivore;
    private Carnivore _carnivore;
    // Constructor
    public AnimalWorld(AnimalFactory factory)
    {
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}