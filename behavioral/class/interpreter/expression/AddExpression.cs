namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public sealed class AddExpression : Expression
  {
    private readonly Expression left;
    private readonly Expression right;

    public AddExpression(Expression left, Expression right)
    {
      this.left = left;
      this.right = right;
    }

    public override double Solve(Context context)
    {
      return
        this.left.Solve(context)
        +
        this.right.Solve(context);
    }
  }
}