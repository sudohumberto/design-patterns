namespace observer_generic;

public class Subject {

    private List<Observer> observers;
    private int mainState;

    public Subject()
    {
        observers = new();
        mainState = 0;
    }

    public void RegisterObserver(Observer observer) {
        if (!observers.Contains(observer)) {
            observers.Add(observer);
        }
    }

    public void UnregisterObserver(Observer observer) {
        if (observers.Contains(observer)) {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers() {
        foreach (Observer observer in observers) {
            observer.Update(mainState);
        }
    }

    public void mainBusinessLogic(int newState) {
        if (mainState != newState) {
            mainState = newState;
            NotifyObservers();
        }
    }

}