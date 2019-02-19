using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.visitor.expression
{
  public class ExpressionUnitTests
  {
    private readonly ITestOutputHelper testOutputHelper;

    public ExpressionUnitTests(ITestOutputHelper testOutputHelper)
    {
      this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test()
    {
      // Arrange
      var addition = new Addition
      (
        new Addition
        (
          new Literal(1),
          new Literal(2)
        ),
        new Literal(3)
      );

      var stringBuilder = new StringBuilder();
      var expressionPrinter = new ExpressionPrinter(stringBuilder);

      // Act
      addition.Accept(expressionPrinter);
      testOutputHelper.WriteLine(stringBuilder.ToString());

      // Assert
      Assert.Equal("((1+2)+3)", stringBuilder.ToString());
    }
  }
}