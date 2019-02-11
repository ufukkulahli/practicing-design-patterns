using Xunit;

namespace practicing_design_patterns.behavioral.@class
{
  public class UnitTests
  {
    [Fact]
    public void Test_Should_CreateMeatSandwich()
    {
      // Arrange
      var meatSandwich = new MeatSandwich();

      // Act
      var sandwich = meatSandwich.Make();

      // Assert
      Assert.NotNull(sandwich);
      Assert.IsAssignableFrom<Sandwich>(sandwich);
    }

    [Fact]
    public void Test_Should_CreateVeggieSandwich()
    {
      // Arrange
      var veggieSandwich = new VeggieSandwich();

      // Act
      var sandwich = veggieSandwich.Make();

      // Assert
      Assert.NotNull(sandwich);
      Assert.IsAssignableFrom<Sandwich>(sandwich);
    }
  }
}