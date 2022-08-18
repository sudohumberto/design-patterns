Console.WriteLine("Hello Builder!");

// Clients can create Products in two different ways:

// Option A: using the Director

Director director = new Director();

IBuilder builder1 = new ConcreteBuilder1();
IBuilder builder2 = new ConcreteBuilder2();

Product productABC = director.BuildProductABC(builder1);
productABC.Show();

// Option B: create a custom product from the builder

builder2.Reset();
builder2.BuildPartA();
builder2.BuildPartB();
builder2.BuildPartB();
builder2.BuildPartA();
Product productABBA = builder2.GetProduct();
productABBA.Show();