namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public class Literal : IExpression
  {
    internal double Value { get; }
    public Literal(double value) => this.Value = value;
    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
  }
}