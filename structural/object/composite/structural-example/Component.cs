using System;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  abstract class Component
  {
    internal abstract void Add(IComponent component);
    internal abstract void Remove(IComponent component);
  }
}
