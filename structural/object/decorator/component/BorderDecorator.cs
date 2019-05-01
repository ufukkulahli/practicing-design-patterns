namespace practicing_design_patterns.structural.@object.decorator.component
{
  class BorderDecorator : Decorator
  {
    BorderDecorator(IComponent component) : base(component)
    {}
    public void Draw()
    {
      base.Draw();
      // TODO:
      // ComponentUnitTests.OutputHelper.WriteLine($", Border");
    }
  }
}
