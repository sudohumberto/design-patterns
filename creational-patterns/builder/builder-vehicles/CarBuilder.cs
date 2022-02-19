
/// <summary>
/// ConcreteBuilder1: Car
/// </summary>
class CarBuilder : Builder
{
    public CarBuilder()
    {
        vehicle = new Vehicle("Car");
    }
    public override void BuildFrame()
    {
        vehicle["frame"] = "Car Frame";
    }
    public override void BuildEngine()
    {
        vehicle["engine"] = "2500 cc";
    }
    public override void BuildWheels()
    {
        vehicle["wheels"] = "4";
    }
    public override void BuildDoors()
    {
        vehicle["doors"] = "4";
    }
}