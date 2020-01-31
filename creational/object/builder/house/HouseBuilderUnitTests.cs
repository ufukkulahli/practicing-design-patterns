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
      houseBuilder
        .BuildWalls(new Wood())
        .BuildWindows(new Wood())
        .BuildDoor(new Wood())
        ;

      // Assert
      Assert.True(true);
    }
  }
}