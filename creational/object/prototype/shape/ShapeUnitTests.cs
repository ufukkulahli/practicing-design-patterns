using Xunit;

namespace practicing_design_patterns.creational.@object.prototype.shape
{
  public class ShapeUnitTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var circle = new Circle();
      circle.X = 5;
      circle.Y = 5;
      circle.Radius = 10;

      // Act

      // Assert
      Assert.True(true);
    }
  }
}