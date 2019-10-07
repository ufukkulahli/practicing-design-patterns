namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class Characteristics
  {
    public readonly string Name;
    public readonly string FrameType;
    public readonly Size Size;

    public Characteristics(string name, string frameType, Size size)
    {
      this.Name = name;
      this.FrameType = frameType;
      this.Size = size;
    }

    public override string ToString() =>
      $"{this.Name}, {this.FrameType}, {this.Size}";
  }
}
