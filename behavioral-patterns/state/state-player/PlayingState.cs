namespace state_player;

public class PlayingState : State
{
    public override void Play(Context context)
    {
        Console.WriteLine("Already playing music.");
    }

    public override void Pause(Context context)
    {
        Console.WriteLine("Pausing music.");
        context.TransitionTo(new PausedState());
    }

    public override void Stop(Context context)
    {
        Console.WriteLine("Stopping music.");
        context.TransitionTo(new StoppedState());
    }
}
