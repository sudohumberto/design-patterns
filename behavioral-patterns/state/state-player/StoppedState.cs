namespace state_player;

public class StoppedState : State
{
    public override void Play(Context context)
    {
        Console.WriteLine("Starting to play music.");
        context.TransitionTo(new PlayingState());
    }

    public override void Pause(Context context)
    {
        Console.WriteLine("Music is stopped, can't pause.");
    }

    public override void Stop(Context context)
    {
        Console.WriteLine("Music is already stopped.");
    }
}
