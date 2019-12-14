namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public sealed class Circle : Shape
  {
    private Radius radius;
    private Coordinate coordinate;

    public Circle(Radius radius, Coordinate coordinate)
    {
      this.radius = radius;
      this.coordinate = coordinate;
    }

    public void Draw() => DrawingEditorUnitTests.Output.WriteLine(this.ToString());

    public override string ToString() =>
      "Circle with radius " + this.radius.ToString() + " at " + this.coordinate.ToString();
  }
}
