using Xunit;

namespace practicing_design_patterns.creational.@object.prototype.sheep
{
  public class SheepUnitTests
  {
    [Fact]
    public void ClonesSheep()
    {
      // Arrange
      var mollyTheSheep = new Sheep("Molly", "Normal");

      // Act
      var dollyTheCloneOfMolly = mollyTheSheep.Clone();
      dollyTheCloneOfMolly.Name("Dolly");

      // Assert
      Assert.Equal("Molly", mollyTheSheep.Name());
      Assert.Equal("Dolly", dollyTheCloneOfMolly.Name());
    }
  }
}