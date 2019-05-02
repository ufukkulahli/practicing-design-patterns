namespace practicing_design_patterns.structural.@object.decorator.component
{
  class TextboxComponent : IComponent
  {
    readonly int width;
    readonly int height;

    internal TextboxComponent(int width, int height)
    {
      this.width = width;
      this.height = height;
    }

    public void Draw()
    {
      ComponentUnitTests.OutputHelper.WriteLine
        ($"Size of textbox: {this.width}:{this.height}");
    }
  }
}
