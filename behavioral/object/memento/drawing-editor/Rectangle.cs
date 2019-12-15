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

    public void Move(Coordinate coordinate) =>
      this.coordinate = this.coordinate.Update(coordinate);

    public IState State() => new RectangleState(this);

    public override string ToString() =>
      "Rectangle with size " + this.size.ToString() + " at " + this.coordinate.ToString();

    private sealed class RectangleState : IState
    {
      private Rectangle rectangle;
      private Size size;
      private Coordinate coordinate;

      public RectangleState(Rectangle rectangle)
      {
        this.rectangle = rectangle;
        this.size = rectangle.size;
        this.coordinate = rectangle.coordinate;
      }
    }
  }
}
