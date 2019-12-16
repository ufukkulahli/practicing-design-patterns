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
    public void DrawsShapesOnEditor()
    {
      // Arrange
      var rectangle = new Rectangle(new Size(5, 20), new Coordinate(10, 10));
      var circle = new Circle(new Radius(20), new Coordinate(20, 20));
      var shapes = new List<Shape> { rectangle, circle };
      var drawingEditor = new DrawingEditor();
      
      drawingEditor.DrawShapes(shapes);
      Assert.Equal("20, 20", circle.Coordinate());
      Assert.Equal("10, 10", rectangle.Coordinate());
      
      // (Save the current place of shapes)
      drawingEditor.SavePlacesOf(shapes);
      
      drawingEditor.Move(shapes);
      Assert.Equal("50, 50", circle.Coordinate());
      Assert.Equal("50, 50", rectangle.Coordinate());

      // Act

      // Assert

    }
  }
}
