// See https://aka.ms/new-console-template for more information
using state_player;

Console.WriteLine("Hello State!");

Context player = new Context(new StoppedState());

player.Play();   // Output: Starting to play music.
player.Pause();  // Output: Pausing music.
player.Play();   // Output: Resuming music.
player.Stop();   // Output: Stopping music.
player.Stop();
player.Pause();