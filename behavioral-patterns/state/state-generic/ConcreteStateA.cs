﻿namespace state_generic;

public class ConcreteStateA : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateA handles request1.");
        Console.WriteLine("ConcreteStateA wants to change the state of the context.");
        this.context.TransitionTo(new ConcreteStateB());
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateA handles request2.");
    }
}
