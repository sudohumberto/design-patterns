
/// <summary>
/// Concrete Factory 1
/// Implements the operations to create concrete animals from Africa
/// </summary>
class AfricaFactory : AnimalFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Giraffe();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}