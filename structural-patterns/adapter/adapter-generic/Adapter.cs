/// <summary>
/// adapts the interface Adaptee to the Target interface.
/// </summary>
public class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();
    public override void Request()
    {
        // Possibly do some other work and then call SpecificRequest
        adaptee.SpecificRequest();
    }
}