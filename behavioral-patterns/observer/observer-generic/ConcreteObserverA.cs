namespace observer_generic;

public class ConcreteObserverA : Observer {
    
    public void Update(int state) {
        System.Console.WriteLine("ConcreteObserverA received notification.");
        System.Console.WriteLine("State: " + state);
    }

}