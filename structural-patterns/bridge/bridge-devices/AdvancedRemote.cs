namespace bridge_devices;

public class AdvancedRemote : Remote
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public void Mute() {
        device.SetVolume(0);
    }

}
