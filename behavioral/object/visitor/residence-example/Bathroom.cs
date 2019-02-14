using System;

namespace practicing_design_patterns.behavioral.@object.visitor
{
  public class Bathroom : IRoom
  {
    public void Accept(IResidenceVisitor visitor)
    {
      visitor.Visit(this);
    }

    public void Clean()
    {
      Console.WriteLine("Room being cleaned...");
    }

    public void Repair()
    {
      Console.WriteLine("Tub being fixed...");
    }
  }
}