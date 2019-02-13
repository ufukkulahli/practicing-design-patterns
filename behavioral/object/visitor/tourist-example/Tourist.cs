namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  internal class Tourist : IVisitor
  {
    public void VisitMuseum(Museum museum)
    {
      museum.TellGreekHistory();
    }

    public void VisitTheater(Theater theater)
    {
      theater.PerformGreekPlay();
    }
  }
}