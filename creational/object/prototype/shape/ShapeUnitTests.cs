using Xunit;

namespace practicing_design_patterns.creational.@object.prototype.shape
{
  public class ShapeUnitTests
  {
    [Fact]
    public void ClonesCircle()
    {
      // Arrange
      var circle = new Circle();
      circle.X = 5;
      circle.Y = 5;
      circle.Radius = 10;

      // Act
      var brandNewCircle = circle.Clone() as Circle;

      // Assert
      Assert.Equal(5, circle.X);
      Assert.Equal(5, circle.Y);
      Assert.Equal(10, circle.Radius);

      Assert.Equal(5, brandNewCircle.X);
      Assert.Equal(5, brandNewCircle.Y);
      Assert.Equal(10, brandNewCircle.Radius);
    }

    [Fact]
    public void ClonesCircleAndUpdatesItsProperties()
    {
      // Arrange
      var circle = new Circle();
      circle.X = 5;
      circle.Y = 5;
      circle.Radius = 10;

      // Act
      var brandNewCircle = circle.Clone() as Circle;
      brandNewCircle.X = 10;
      brandNewCircle.Y = 10;
      brandNewCircle.Radius = 20;

      // Assert
      Assert.Equal(5, circle.X);
      Assert.Equal(5, circle.Y);
      Assert.Equal(10, circle.Radius);

      Assert.Equal(10, brandNewCircle.X);
      Assert.Equal(10, brandNewCircle.Y);
      Assert.Equal(20, brandNewCircle.Radius);
    }
  }
}