namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public interface IExpressionVisitor
  {
    void Visit(Literal literal);
    void Visit(Addition addition);
  }
}