
class FrenchBakery : Bakery
{
    public override Bread CreateBread() 
    {
        return new Croissant();
    }
}