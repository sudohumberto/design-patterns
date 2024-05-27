
public class Abstraction {

    protected IImplementation implementation;

    public Abstraction(IImplementation implementation)
    {
        this.implementation = implementation;
    }

    public void Feature1() {
        implementation.Method1();
    }

    public void Feature2() {
        implementation.Method2();
        implementation.Method3();
    }

}