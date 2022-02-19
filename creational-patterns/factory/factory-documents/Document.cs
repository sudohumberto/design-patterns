
/// <summary>
/// (Abstract) Creator
///
/// Declares the factory method (CreatePages), which returns one or more objects of type Page (Product).
/// </summary>
abstract class Document
{
    private List<Page> _pages = new List<Page>();
    // Constructor calls abstract Factory method
    public Document()
    {
        this.CreatePages();
    }
    public List<Page> Pages
    {
        get { return _pages; }
    }
    // Factory Method
    public abstract void CreatePages();
}