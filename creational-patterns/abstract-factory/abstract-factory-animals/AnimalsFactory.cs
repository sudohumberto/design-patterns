
/// <summary>
/// Abstract Factory
/// declares an interface for operations that create abstract animals
/// </summary>
public abstract class AnimalsFactory
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}