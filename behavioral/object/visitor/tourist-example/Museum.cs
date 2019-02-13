using System;

namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  internal class Museum : IVisitee
  {
    private const string GreekHistory =
      "Greece is a country in southeastern Europe, " +
      "known in Greek as Hellas or Ellada, " +
      "and consisting of a mainland and an archipelago...";

    public void Accept(IVisitor visitor)
    {
      visitor.VisitMuseum(this);
    }

    public void TellGreekHistory()
    {
      Console.WriteLine(GreekHistory);
    }
  }
}