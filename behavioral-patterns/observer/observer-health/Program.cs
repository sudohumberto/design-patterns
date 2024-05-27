// See https://aka.ms/new-console-template for more information
using observer_health;

Console.WriteLine("Hello Observer!");

Subject subject = new();

Doctor doctorSmith = new("Smith");
FamilyMember jenny = new("Jenny");

subject.RegisterObserver(doctorSmith);
subject.RegisterObserver(jenny);

/* Change State that does not trigger notifications */
subject.mainBusinessLogic(90);

/* Change State that trigger notifications */
subject.mainBusinessLogic(110);
