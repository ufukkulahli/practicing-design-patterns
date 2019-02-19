namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public class Addition : IExpression
  {
    internal IExpression Left { get; }
    internal IExpression Right { get; }
    
    public Addition(IExpression left, IExpression right)
    {
      this.Left = left;
      this.Right = right;
    }
    
    public void Accept(IExpressionVisitor visitor) => visitor.Visit(this);
  }
}