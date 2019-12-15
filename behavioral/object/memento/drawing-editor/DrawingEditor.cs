using System;
using System.Collections.Generic;

namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public sealed class DrawingEditor
  {
    private ICollection<IState> savedStates = new List<IState>();

    public void DrawShapes(IEnumerable<Shape> shapes)
    {
      foreach(var shape in shapes)
      {
        shape.Draw();
      }
    }

    public void Save(IEnumerable<Shape> shapes)
    {
      foreach(var shape in shapes)
      {
        this.savedStates.Add(shape.State());
      }
    }

    public void Move(IEnumerable<Shape> shapes)
    {
      foreach(var shape in shapes)
      {
        shape.Move(new Coordinate(50, 50));
      }
    }
  }
}
