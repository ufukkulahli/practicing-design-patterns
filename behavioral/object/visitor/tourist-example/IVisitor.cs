namespace practicing_design_patterns.behavioral.@object.visitor
{
  internal interface IVisitor
  {
    void VisitMuseum(Museum museum);
    void VisitTheater(Theater theater);
  }
}