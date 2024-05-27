namespace bridge_devices;

public class Radio : IDevice
{
    private bool isEnabled;
    private int volume;
    private int channel;

    public Radio()
    {
        isEnabled = false;
        volume = 20;
        channel = 88;
    }

    public void Disable()
    {
        isEnabled = false;
        System.Console.WriteLine("Radio is disabled.");
    }

    public void Enable()
    {
        isEnabled = true;
        System.Console.WriteLine("Radio is enabled.");
    }

    public int GetChannel()
    {
        System.Console.WriteLine("Radio Channel: " + channel);
        return channel;
    }

    public int GetVolume()
    {
        System.Console.WriteLine("Radio Volume: " + volume);
        return volume;
    }

    public bool IsEnabled()
    {
        return isEnabled;
    }

    public void SetChannel(int channel)
    {
        if (channel < 88 || channel > 108) {
            System.Console.WriteLine("Invalid Radio Channel");
            return;
        }
        this.channel = channel;
        System.Console.WriteLine("Radio Channel: " + channel);
    }

    public void SetVolume(int volume)
    {
        this.volume = volume;
        System.Console.WriteLine("Radio Volume: " + volume);
    }
}
