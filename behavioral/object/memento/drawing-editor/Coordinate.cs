namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public struct Coordinate
  {
    private readonly int x;
    private readonly int y;

    public Coordinate(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public override string ToString() => this.x + ", " + this.y;
  }
}
