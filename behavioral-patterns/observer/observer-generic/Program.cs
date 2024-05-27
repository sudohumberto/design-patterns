// See https://aka.ms/new-console-template for more information
using observer_generic;

Console.WriteLine("Hello Observer!");

Subject subject = new();

ConcreteObserverA observerA = new();
ConcreteObserverB observerB = new();

subject.RegisterObserver(observerA);
subject.RegisterObserver(observerB);

/* Change State to trigger notifications */
subject.mainBusinessLogic(1);
subject.mainBusinessLogic(2);
