using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public class DrawingEditorUnitTests
  {
    public static ITestOutputHelper Output;
    public DrawingEditorUnitTests(ITestOutputHelper output) => Output = output;

    [Fact]
    public void Test()
    {
      // Arrange
      var rectangle = new Rectangle(new Size(5, 20), new Coordinate(10, 10));
      var circle = new Circle(new Radius(20), new Coordinate(20, 20));
      var shapes = new List<Shape> { rectangle, circle };
      var drawingEditor = new DrawingEditor();
      drawingEditor.DrawShapes(shapes);
      drawingEditor.Save(shapes);

      // Act

      // Assert

    }
  }
}
