namespace practicing_design_patterns.behavioral.@object.memento.drawing_editor
{
  public struct Radius
  {
    private readonly int value;
    public Radius(int value) => this.value = value;
    public override string ToString() => this.value.ToString();
  }
}
