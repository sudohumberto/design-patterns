namespace state_player;

public class Context
{
    private State state;

    public Context(State state)
    {
        this.state = state;
    }

    public void TransitionTo(State state)
    {
        Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
        this.state = state;
        this.state.SetContext(this);
    }

    public void Play() {
        state.Play(this);
    }

    public void Pause() {
        state.Pause(this);
    }

    public void Stop() {
        state.Stop(this);
    }

}
