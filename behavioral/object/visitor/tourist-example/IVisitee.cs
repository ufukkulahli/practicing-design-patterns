namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  internal interface IVisitee
  {
    void Accept(IVisitor visitor);
  }
}