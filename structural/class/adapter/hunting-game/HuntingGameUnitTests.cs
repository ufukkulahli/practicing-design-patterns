using Xunit;
using practicing_design_patterns.structural.@object.adapter.hunting_game; 

namespace practicing_design_patterns.structural.@class.adapter.hunting_game
{
  public class HuntingGameUnitTests
  {
    [Fact]
    public void MissesWildDogHunt()
    {
      // Arrange
      var wildDog = new WildDogClassAdapter();
      var hunter = new Hunter();

      // Act
      var result = hunter.Hunt(wildDog);

      // Assert
      Assert.Equal("Missed!", result);
    }
  }
}