
/// <summary>
/// ConcretePrototype
/// Implements an operation for cloning itself
/// </summary>
public class Person : PersonPrototype
{
    public string Name= null!;
    public DateTime BirthDate;
    public string Country = null!;
    public IdInfo IdInfo = null!;

    // Shallow Copy
    public override Person Clone()
    {
        return (Person) this.MemberwiseClone();
    }

    // Deep Copy
    public Person DeepCopy()
    {
        Person clone = (Person) this.MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = new string(Name);
        return clone;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Country: {Country}, BirthDate: {BirthDate.ToShortDateString()}, Id: {IdInfo.IdNumber}";
    }
}