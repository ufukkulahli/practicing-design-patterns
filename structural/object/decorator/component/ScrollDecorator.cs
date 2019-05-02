namespace practicing_design_patterns.structural.@object.decorator.component
{
  class ScrollDecorator : Decorator
  {
    internal ScrollDecorator(IComponent component) : base(component)
    {}
    public void Draw()
    {
      base.Draw();
      ComponentUnitTests.OutputHelper.WriteLine($", Scroll");
    }
  }
}
