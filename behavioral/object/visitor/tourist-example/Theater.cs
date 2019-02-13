using System;

namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  internal class Theater : IVisitee
  {
    public void Accept(IVisitor visitor)
    {
      visitor.VisitTheater(this);
    }

    public void PerformGreekPlay()
    {
      Console.WriteLine("Play about Socrates is going to begin in 5 minutes...");
    }
  }
}