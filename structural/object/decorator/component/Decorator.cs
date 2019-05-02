namespace practicing_design_patterns.structural.@object.decorator.component
{
  abstract class Decorator : IComponent
  {
    internal readonly IComponent component;
    internal Decorator(IComponent component)=>this.component=component;
    public void Draw()=>this.component.Draw();
  }
}
