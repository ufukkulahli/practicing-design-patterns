namespace practicing_design_patterns.structural.@object.decorator.component
{
  class Textbox : IComponent
  {
    readonly int width;
    readonly int height;

    Textbox(int width, int height)
    {
      this.width = width;
      this.height = height;
    }

    public void Draw()
    {
      // TODO:
      // ComponentUnitTests.OutputHelper.WriteLine($"Size of textbox: {this.width}:{this.height}");
    }
  }
}
