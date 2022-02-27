/// <summary>
/// Defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
/// Responsible for creating and maintaining its own unique instance.
/// </summary>
public class Singleton
{
    static Singleton instance = null!;

    public int IntegerValue;
    
    // Constructor is 'protected'
    protected Singleton()
    {
        IntegerValue = 0;
    }

    public static Singleton Instance()
    {
        // Uses lazy initialization.
        // Note: this is not thread safe.
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}