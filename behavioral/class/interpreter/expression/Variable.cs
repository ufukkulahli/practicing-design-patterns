namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public sealed class Variable : Expression
  {
    private readonly string name;

    public Variable(string name)
    {
      this.name = name;
    }

    public override double Solve(Context context)
    {
      return
        context
        .GetVariable(this.name)
        .Solve(context);
    }
  }
}