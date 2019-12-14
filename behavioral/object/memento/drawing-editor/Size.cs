namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public struct Size
  {
    private readonly int side1;
    private readonly int side2;

    public Size(int side1, int side2)
    {
      this.side1 = side1;
      this.side2 = side2;
    }

    public override string ToString() => this.side1 + "x" + this.side2;
  }
}
