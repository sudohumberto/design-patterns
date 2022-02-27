/// <summary>
/// Defines the domain-specific interface that Client uses.
/// </summary>
public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("Called Target Request()");
    }
}