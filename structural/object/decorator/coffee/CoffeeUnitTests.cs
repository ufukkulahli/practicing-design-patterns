using Xunit;

namespace practicing_design_patterns.structural.@object.decorator.coffee
{
  public class CoffeeUnitTests
  {
    [Fact]
    public void ShouldAssertCostOfFilterCoffeeAs10()
    {
      // Arrange
      var coffee = new FilterCoffee();

      // Act & Assert
      Assert.Equal(10, coffee.Cost());
    }
    [Fact]
    public void ShouldAssertCostOfFilterCoffeeWithMilkWithSugarAs16()
    {
      // Arrange
      var filterCoffeeWithMilkWithSugar = new Sugar(new Milk(new FilterCoffee()));

      // Act & Assert
      Assert.Equal(16, filterCoffeeWithMilkWithSugar.Cost());
    }
  }
}