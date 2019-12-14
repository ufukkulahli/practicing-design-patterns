namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public sealed class Rectangle : Shape
  {
    private Size size;
    private Coordinate coordinate;

    public Rectangle(Size size, Coordinate coordinate)
    {
      this.size = size;
      this.coordinate = coordinate;
    }

    public void Draw() => DrawingEditorUnitTests.Output.WriteLine(this.ToString());

    public override string ToString() =>
      "Rectangle with size " + this.size.ToString() + " at " + this.coordinate.ToString();
  }
}
