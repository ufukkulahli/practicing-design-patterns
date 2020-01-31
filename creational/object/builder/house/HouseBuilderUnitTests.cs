using System;
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
        .Walls(new Wood())
        .Windows(new Wood())
        .Door(new Wood())
        .Roof(new Wood());

      // Assert
      Assert.Throws<NotImplementedException>(() => houseBuilder.Build());
    }
  }
}