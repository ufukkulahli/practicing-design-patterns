using System.Text;

namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public class ExpressionPrinter : IExpressionVisitor
  {
    private readonly StringBuilder stringBuilder;

    public ExpressionPrinter(StringBuilder stringBuilder) => this.stringBuilder = stringBuilder;

    public void Visit(Literal literal) => stringBuilder.Append(literal.Value);

    public void Visit(Addition addition)
    {
      stringBuilder.Append("(");
      addition.Left.Accept(this);
      stringBuilder.Append("+");
      addition.Right.Accept(this);
      stringBuilder.Append(")");
    }
  }
}