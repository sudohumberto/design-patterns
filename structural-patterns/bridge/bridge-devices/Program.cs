// See https://aka.ms/new-console-template for more information
using bridge_devices;

Console.WriteLine("Hello Bridge!");

TV tv = new();
Remote remote = new(tv);
remote.TogglePower();
remote.ChannelUp();
remote.VolumeUp();

Radio radio = new();
AdvancedRemote advancedRemote = new(radio);
advancedRemote.TogglePower();
advancedRemote.ChannelUp();
advancedRemote.VolumeUp();
