using Xunit;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@class.interpreter.roman_numeral
{
  public class RomanNumeralUnitTests
  {
    [Fact]
    public void InterpretsRomanNumeral()
    {
      // Arrange
      var tree = new List<Expression>();
      tree.Add(new ThousandExpression());
      tree.Add(new HundredExpression());
      tree.Add(new TenExpression());
      tree.Add(new OneExpression());

      var roman = "MCMXXVIII";
      var context = new Context();
      context.Input = roman;

      // Act
      foreach(var expression in tree)
      {
        expression.Interpret(context);
      }

      // Assert
      Assert.Equal(1928, context.Output);
    }
  }
}