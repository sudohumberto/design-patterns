namespace state_player;

public abstract class State
{
    protected Context context;

    public void SetContext(Context context)
    {
        this.context = context;
    }

    public abstract void Play(Context context);
    public abstract void Pause(Context context);
    public abstract void Stop(Context context);
}
