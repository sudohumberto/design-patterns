﻿namespace state_generic;

public abstract class State
{
    protected Context context = null;

    public void SetContext(Context context)
    {
        this.context = context;
    }

    public abstract void Handle1();
    public abstract void Handle2();
}
