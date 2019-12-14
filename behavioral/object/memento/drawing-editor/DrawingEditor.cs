using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public sealed class DrawingEditor
  {
    public void DrawShapes(IEnumerable<Shape> shapes)
    {
      foreach(var shape in shapes)
      {
        shape.Draw();
      }
    }
  }
}
