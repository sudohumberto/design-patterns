// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Builder in Real World!");


Builder builder;

// Create director with vehicle builders

Director director = null!;

// Construct and display vehicles

builder = new CarBuilder();
director = new Director(builder);
builder.Vehicle.Show();

builder = new MotorCycleBuilder();
director = new Director(builder);
builder.Vehicle.Show();