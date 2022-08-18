
/// <summary>
/// Constructs an object using the Builder interface
/// The director knows which building steps to execute to get a working product.
/// </summary>
class KyotoDirector
{
    public Sushi BuildSpiderRoll(ISushiBuilder builder)
    {
        builder.Reset();
        builder.BuildRice();
        builder.BuildNori();
        builder.BuildFish("Fried soft-shell crab");
        builder.BuildVeggie("Cucumber");
        builder.BuildVeggie("Avocado");
        builder.BuildSauce("SpicyMayo");
        return builder.GetRoll();
    }

    public Sushi BuildRainbowRoll(ISushiBuilder builder)
    {
        builder.Reset();
        builder.BuildRice();
        builder.BuildNori();
        builder.BuildFish("Yellowtail");
        builder.BuildFish("Tuna");
        builder.BuildFish("Salmon");
        builder.BuildFish("Snapper");
        builder.BuildFish("Eel");
        builder.BuildVeggie("Avocado");
        return builder.GetRoll();
    }
}