namespace practicing_design_patterns.behavioral.@object.visitor
{
  public interface IResidenceVisitor
  {
    void Visit(Bathroom room);
    void Visit(Bedroom room);
    void Visit(Kitchen room);
    void Visit(LivingRoom room);
  }
}