namespace bridge_devices;

public class TV : IDevice
{
    private bool isEnabled;
    private int volume;
    private int channel;

    public TV()
    {
        isEnabled = false;
        volume = 10;
        channel = 1;
    }

    public void Disable()
    {
        isEnabled = false;
        System.Console.WriteLine("TV is disabled.");
    }

    public void Enable()
    {
        isEnabled = true;
        System.Console.WriteLine("TV is enabled.");
    }

    public int GetChannel()
    {
        System.Console.WriteLine("TV Channel: " + channel);
        return channel;
    }

    public int GetVolume()
    {
        System.Console.WriteLine("TV Volume: " + volume);
        return volume;
    }

    public bool IsEnabled()
    {
        return isEnabled;
    }

    public void SetChannel(int channel)
    {
        if (channel < 0 || channel > 999) {
            System.Console.WriteLine("Invalid TV Channel");
            return;
        }
        this.channel = channel;
        System.Console.WriteLine("TV Channel: " + channel);
    }

    public void SetVolume(int volume)
    {
        this.volume = volume;
        System.Console.WriteLine("TV Volume: " + volume);
    }

}
