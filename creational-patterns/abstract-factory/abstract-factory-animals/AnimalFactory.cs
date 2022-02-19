
/// <summary>
/// Abstract Factory
/// declares an interface for operations that create abstract animals
/// </summary>
abstract class AnimalFactory
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}