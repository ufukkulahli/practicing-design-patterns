namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public sealed class SubtractExpression : Expression
  {
    private readonly Expression left;
    private readonly Expression right;

    public SubtractExpression(Expression left, Expression right)
    {
      this.left = left;
      this.right = right;
    }

    public override double Solve(Context context)
    {
      return
        this.left.Solve(context)
        -
        this.right.Solve(context);
    }
  }
}