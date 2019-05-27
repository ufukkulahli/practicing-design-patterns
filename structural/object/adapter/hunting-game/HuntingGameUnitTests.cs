using Xunit;

namespace practicing_design_patterns.structural.@object.adapter.hunting_game
{
  public class HuntingGameUnitTests
  {
    [Fact]
    public void MissesLionHunt()
    {
      // Arrange
      var africanLion = new AfricanLion();
      var hunter = new Hunter();

      // Act
      var result = hunter.Hunt(africanLion);

      // Assert
      Assert.Equal("Missed!", result);
    }

    [Fact]
    public void MissesWildDogHunt()
    {
      // Arrange
      var wildDog = new WildDogAdapter(new WildDog());
      var hunter = new Hunter();

      // Act
      var result = hunter.Hunt(wildDog);

      // Assert
      Assert.Equal("Missed!", result);
    }
  }
}