namespace practicing_design_patterns.behavioral.@object.visitor
{
  public interface IEmployee
  {
    void PrintStructures();
    void Accept(IEmployeeVisitor visitor);
  }
}