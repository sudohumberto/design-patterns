public class RefinedAbstraction : Abstraction {

    public RefinedAbstraction(IImplementation implementation) : base(implementation)
    {
    }

    public void FeatureN() {
        implementation.MethodN();
        implementation.MethodM();
    }
    
}