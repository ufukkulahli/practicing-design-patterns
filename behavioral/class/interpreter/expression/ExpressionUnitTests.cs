using Xunit;

namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public class ExpressionUnitTests
  {
    [Fact]
    public void AddsTwoNumbers()
    {
      // Arrange
      var adding = new AddExpression(new ConstantExpression(1), new ConstantExpression(1));

      // Act
      var result = adding.Solve(new Context());

      // Assert
      Assert.Equal(2, result);
    }
    
    [Fact]
    public void DoesLittleBitMoreComplicatedCalculation()
    {
      // Arrange
      var adding = new AddExpression(new ConstantExpression(1), new ConstantExpression(1));
      var subtracting = new SubtractExpression(new ConstantExpression(4), new ConstantExpression(2));
      var subtractingResult = new SubtractExpression(adding, subtracting);

      // Act
      var result = subtractingResult.Solve(null);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void CalculatesExpressionWithVariable()
    {
      // Arrange
      var adding = new AddExpression(new ConstantExpression(1), new Variable("n"));
      var subtracting = new SubtractExpression(new ConstantExpression(4), new Variable("n"));
      var subtractingResult = new SubtractExpression(adding, subtracting);
      var n = 3;
      var context = new Context();
      context.SetVariable("n", new ConstantExpression(n));

      // Act
      var result = subtractingResult.Solve(context);

      // Assert
      Assert.Equal((1+n)-(4-n), result);
      Assert.Equal(3, result);
    }
  }
}