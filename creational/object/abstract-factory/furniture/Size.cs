namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public struct Size
  {
    public readonly int Width;
    public readonly int Height;
    public readonly int Depth;

    public Size(int Width, int Height, int Depth)
    {
      this.Width = Width;
      this.Height = Height;
      this.Depth = Depth;
    }
    public override string ToString() =>
      $"{this.Width}x{this.Height}x{this.Depth}";
  }
}
