namespace practicing_design_patterns.creational.@object.prototype.shape
{
  public sealed class Rectangle : Shape
  {
    public Rectangle() { }
    public Rectangle(Rectangle rectangle) : base(rectangle) { }
    public override Shape Clone() => new Rectangle(this);
  }
}