using Xunit;

namespace practicing_design_patterns.behavioral.@class
{
  public class BeverageUnitTests
  {
    [Fact]
    public void Test_Should_PrepareTea()
    {
      // Arrange
      var tea = new Tea
      {
        WantsCondiments = true,
        AddSugar = 5
      };

      // Act
      var beverage = tea.Prepare();

      // Assert
      Assert.NotNull(beverage);
      Assert.IsAssignableFrom<Tea>(beverage);
    }

    [Fact]
    public void Test_Should_PrepareCoffe()
    {
      // Arrange
      var coffee = new Coffee
      {
        WantsCondiments = true
      };

      // Act
      var beverage = coffee.Prepare();

      // Assert
      Assert.NotNull(beverage);
      Assert.IsAssignableFrom<Coffee>(beverage);
    }
  }
}