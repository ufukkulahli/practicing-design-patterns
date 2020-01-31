using Xunit;

namespace practicing_design_patterns.creational.@object.builder.house
{
  public class HouseBuilderUnitTests
  {
    [Fact]
    public void BuildsHouse()
    {
      // Arrange
      var houseBuilder = new HouseBuilder();

      // Act

      // Assert
      Assert.True(true);
    }
  }
}