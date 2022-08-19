
class GermanBakery : Bakery
{
    public override Bread CreateBread() 
    {
        return new Bretzel();
    }
}