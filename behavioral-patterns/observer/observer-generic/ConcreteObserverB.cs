namespace observer_generic;

public class ConcreteObserverB : Observer {

    public void Update(int state) {
        System.Console.WriteLine("ConcreteObserverB received notification.");
        System.Console.WriteLine("State: " + state);
    }
    
}