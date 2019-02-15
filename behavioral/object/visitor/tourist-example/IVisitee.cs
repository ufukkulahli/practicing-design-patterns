namespace practicing_design_patterns.behavioral.@object.visitor
{
  internal interface IVisitee
  {
    void Accept(IVisitor visitor);
  }
}