namespace observer_health;

public class Doctor : Observer
{
    private string name;

    public Doctor(string name)
    {
        this.name = name;
    }

    public void Update(int heartRate)
    {
        System.Console.WriteLine("Dr. " + name + " received the notification.");
        System.Console.WriteLine("Hearth rate: " + heartRate);
    }
}
