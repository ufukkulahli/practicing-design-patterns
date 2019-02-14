namespace practicing_design_patterns.behavioral.@object.visitor
{
  public interface IRoom
  {
    void Accept(IResidenceVisitor visitor);
  }
}