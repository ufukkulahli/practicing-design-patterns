namespace practicing_design_patterns.structural.@object.decorator.component
{
  class ScrollDecorator : Decorator
  {
    ScrollDecorator(IComponent component) : base(component)
    {}
    public void Draw()
    {
      base.Draw();
      // TODO:
      // ComponentUnitTests.OutputHelper.WriteLine($", Scroll");
    }
  }
}
