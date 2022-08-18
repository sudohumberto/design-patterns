
/// <summary>
/// Concrete Factory 2
/// Implements the operations to create concrete animals from America
/// </summary>
public class AmericaFactory : AnimalsFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}