namespace observer_health;

public class Subject
{
    private List<Observer> observers;
    private int heartRate;

    public Subject()
    {
        observers = new();
        heartRate = 80;
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
            observer.Update(heartRate);
        }
    }

    public void mainBusinessLogic(int newHeartRate) {
        if (newHeartRate < 60 || newHeartRate > 100) {
            heartRate = newHeartRate;
            NotifyObservers();
        }
    }
}
