using System;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  abstract class Component
  {
    protected string name;
    internal Component(string name)=>this.name=name;
    internal abstract void Add(Component component);
    internal abstract void Remove(Component component);
    internal abstract void Display(int depth);
  }
  
  class Composite : Component
  {}
  
}
