namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  internal abstract class Component
  {
    internal abstract void Add(IComponent component);
    internal abstract void Remove(IComponent component);
  }
}