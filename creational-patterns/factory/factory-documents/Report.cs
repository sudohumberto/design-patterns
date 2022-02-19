
/// <summary>
/// ConcreteCreator
/// Overrides the factory method (CreatePages) to return one or more instances of a ConcreteProducts.
/// Report instanciate: IntroductionPage (ConcreteProduct4), ResultsPage (ConcreteProduct5), ConclusionPage (ConcreteProduct6),
///     SummaryPage (ConcreteProduct7) and BibliographyPage (ConcreteProduct8)
/// </summary>
class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }