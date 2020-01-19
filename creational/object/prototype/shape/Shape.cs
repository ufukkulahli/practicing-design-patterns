namespace practicing_design_patterns.creational.@object.prototype.shape
{
  public abstract class Shape
  {
    public int X { get; internal set; }
    public int Y { get; internal set; }
    public string Color { get; internal set; }

    public Shape() { }

    protected Shape(Shape source)
    {
      this.X = source.X;
      this.Y = source.Y;
      this.Color = source.Color;
    }

    public abstract Shape Clone();
  }
}