namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public sealed class ConstantExpression : Expression
  {
    private readonly double number;

    public ConstantExpression(double number) => this.number = number;

    public override double Solve(Context context)
    {
      return this.number;
    }
  }
}