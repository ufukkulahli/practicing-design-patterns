using Xunit;

namespace practicing_design_patterns.structural.@object.flyweight.tree
{
  public class TreeUnitTests
  {
    [Fact]
    public void CreatesLightweightTrees()
    {
      // Arrange
      var forest = new Forest();

      // Act
      forest.GrowTrees(new TreeCanvas());

      // Assert
      Assert.Equal(3, forest.TreeCount());
    }
  }
}
