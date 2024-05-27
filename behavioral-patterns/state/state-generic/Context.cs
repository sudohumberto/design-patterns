namespace state_generic;

public class Context
{
    private State state = null;

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

    public void Request1() {
        this.state.Handle1();
    }

    public void Request2() {
        this.state.Handle2();
    }

}
