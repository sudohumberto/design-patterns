
/// <summary>
/// ConcreteCreator
/// Overrides the factory method (CreatePages) to return one or more instances of a ConcreteProducts.
/// Resume instanciate SkillsPage (ConcreteProduct1), EducationPage (ConcreteProduct2) and ExperiencePage (ConcreteProduct3)
/// </summary>
class Resume : Document
{
    // Factory Method implementation
    public override void CreatePages()
    {
        Pages.Add(new SkillsPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
    }
}