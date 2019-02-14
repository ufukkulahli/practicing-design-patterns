using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Bedroom : IRoom
  {
    public void Accept(IResidenceVisitor visitor)
    {
      visitor.Visit(this);
    }

    public void Clean()
    {
      Console.WriteLine("Room being cleaned...");
    }
  }
}