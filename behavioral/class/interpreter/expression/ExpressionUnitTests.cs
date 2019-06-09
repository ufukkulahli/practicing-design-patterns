using Xunit;

namespace practicing_design_patterns.behavioral.@class.interpreter.expression
{
  public class ExpressionUnitTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var adding = new AddExpression(new ConstantExpression(1), new ConstantExpression(1));

      // Act
      var result = adding.Solve(new Context());

      // Assert
      Assert.Equal(2, result);
    }
  }
}