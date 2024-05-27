namespace observer_health;

public class FamilyMember : Observer
{
    private string name;

    public FamilyMember(string name)
    {
        this.name = name;
    }

    public void Update(int heartRate)
    {
        System.Console.WriteLine(name + " received the notification.");
        System.Console.WriteLine("Hearth rate: " + heartRate);
    }
}
