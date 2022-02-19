# Factory

![factory-method-en-2x](images/factory-method-en-2x.png)

> The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses. (dofactory)

> Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. (Refactoring Guru)

> Define an interface for creating an object, but let subclasses decide which class to instantiate. The Factory Method pattern lets a class defer instantiation to subclasses. (Sarcar, 2018)

:boom: Create Objects, each one made from different products. ObjectA is made of of Product2 and Product5, ObjectB is made of Product1, Product2 and Product3.

## UML

![factory-structure-2x](images/factory-structure-2x.png)


## Participants

* Product  (`Page`)
    * defines the interface of objects the factory method creates
* ConcreteProduct  (`SkillsPage`, `EducationPage`, `ExperiencePage`)
    * implements the Product interface
* Creator  (`Document`)
    * declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    * may call the factory method to create a Product object.
* ConcreteCreator  (`Report`, `Resume`)
    * overrides the factory method to return an instance of a ConcreteProduct.

## Pros and Cons
 
<!-- Pros -->

:heavy_check_mark: You avoid tight coupling between the creator and the concrete products.

:heavy_check_mark: **Single Responsibility Principle**. You can move the product creation code into one place in the program, making the code easier to support.

:heavy_check_mark: **Open/Closed Principle**. You can introduce new types of products into the program without breaking existing client code.

<!-- cons -->

:x: The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.