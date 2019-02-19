namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public interface IExpression
  {
    void Accept(IExpressionVisitor visitor);
  }
}