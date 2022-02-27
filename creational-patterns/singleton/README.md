# Singleton

![singleton](images/singleton.png)

> The Singleton design pattern ensures a class has only one instance and provide a global point of access to it. (dofactory)

> Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance. (Refactoring Guru)

> Ensure a class has only one instance, and provide a global point of access to it. (Sarcar, 2018)

:boom: .

## UML

![structure-en-indexed](images/structure-en-indexed.png)


## Participants

* Singleton (`LoadBalancer`)
    * defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
    * responsible for creating and maintaining its own unique instance.

## Pros and Cons
 
<!-- Pros -->

:heavy_check_mark: You can be sure that a class has only a single instance.

:heavy_check_mark: You gain a global access point to that instance.

:heavy_check_mark: The singleton object is initialized only when it’s requested for the first time.

<!-- cons -->

:x: Violates the Single Responsibility Principle. The pattern solves two problems at the time.

:x: The Singleton pattern can mask bad design, for instance, when the components of the program know too much about each other.

:x: The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
 
:x: It may be difficult to unit test the client code of the Singleton because many test frameworks rely on inheritance when producing mock objects. Since the constructor of the singleton class is private and overriding static methods is impossible in most languages, you will need to think of a creative way to mock the singleton. Or just don’t write the tests. Or don’t use the Singleton pattern.