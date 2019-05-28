namespace practicing_design_patterns.structural.@object.decorator.component
{
  class BorderDecorator : Decorator
  {
    internal BorderDecorator(IComponent component) : base(component)
    {}
    public new void Draw()
    {
      base.Draw();
      ComponentUnitTests.OutputHelper.WriteLine($", Border");
    }
  }
}
