using Xunit;

namespace practicing_design_patterns.creational.@object.builder.house
{
  public class HouseBuilderUnitTests
  {
    [Fact]
    public void BuildsWoodenHouse()
    {
      // Arrange
      var houseBuilder = new HouseBuilder();

      // Act
      var woodenHouse = houseBuilder
                          .Walls(new Wood())
                          .Windows(new Wood())
                          .Door(new Wood())
                          .Roof(new Wood())
                          .Build();

      // Assert
      Assert.Equal
      (
        "Wall is wooden material. Window is wooden material. Door is wooden material. Roof is wooden material.",
        woodenHouse.MadeFrom()
      );
    }

    [Fact]
    public void BuildsStoneHouse()
    {
      // Arrange
      var houseBuilder = new HouseBuilder();

      // Act
      var stoneHouse = houseBuilder
                          .Walls(new Stone())
                          .Windows(new Wood())
                          .Door(new Wood())
                          .Roof(new Stone())
                          .Build();

      // Assert
      Assert.Equal
      (
        "Wall is stone material. Window is wooden material. Door is wooden material. Roof is stone material.",
        stoneHouse.MadeFrom()
      );
    }
  }
}