namespace practicing_design_patterns.structural.@object.decorator.component
{
  abstract class Decorator : IComponent
  {
    readonly IComponent component;
    Decorator(IComponent component)=>this.component=component;
    public void Draw()=>this.component.Draw();
  }
}
