using Xunit;

namespace practicing_design_patterns.creational.@object.prototype.robot
{
  public class RobotUnitTests
  {
    [Fact]
    public void ClonesRobot()
    {
      // Arrange
      var bender = new Robot("Bender", "A metal bending unit");

      // Act
      var calculon = bender.Clone();
      calculon.Name("Calculon");
      calculon.Purpose("An actor unit");

      // Assert
      Assert.Equal("Calculon", calculon.Name());
      Assert.Equal("An actor unit", calculon.Purpose());
    }
  }
}