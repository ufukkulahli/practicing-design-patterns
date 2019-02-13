namespace practicing_design_patterns.behavioral.@object.visitor.tourist_example
{
  internal interface IVisitor
  {
    void VisitMuseum(Museum museum);
    void VisitTheater(Theater theater);
  }
}