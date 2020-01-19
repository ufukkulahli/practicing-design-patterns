namespace practicing_design_patterns.creational.@object.prototype.shape
{
  public sealed class Circle : Shape
  {
    public int Radius { get; internal set; }
    public Circle() { }
    public Circle(Circle circle) : base(circle) => this.Radius = circle.Radius;
    public override Shape Clone() => new Circle(this);
  }
}