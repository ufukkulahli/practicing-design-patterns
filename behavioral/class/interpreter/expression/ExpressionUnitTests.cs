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
  }
}