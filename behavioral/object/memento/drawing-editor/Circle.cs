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

    public void Move(Coordinate coordinate) =>
      this.coordinate = this.coordinate.Update(coordinate);

    public IState State() => new CircleState(this);

    public override string ToString() =>
      "Circle with radius " + this.radius.ToString() + " at " + this.coordinate.ToString();

    private sealed class CircleState : IState
    {
      private Circle circle;
      private Radius radius;
      private Coordinate coordinate;

      public CircleState(Circle circle)
      {
        this.circle = circle;
        this.radius = circle.radius;
        this.coordinate = circle.coordinate;
      }
    }

    public string Coordinate() => this.coordinate.ToString();
  }
}
