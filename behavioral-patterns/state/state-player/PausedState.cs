namespace state_player;

public class PausedState : State
{
    public override void Play(Context context)
    {
        Console.WriteLine("Resuming music.");
        context.TransitionTo(new PlayingState());
    }

    public override void Pause(Context context)
    {
        Console.WriteLine("Music is already paused.");
    }

    public override void Stop(Context context)
    {
        Console.WriteLine("Stopping music.");
        context.TransitionTo(new StoppedState());
    }
}
