using System.Linq;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  internal class CompositeComponent : Component, IComponent
  {
    private readonly ICollection<IComponent> children = new List<IComponent>();
    private readonly string name;

    internal CompositeComponent(string name)
    {
      this.name = name;
    }

    public string Name()
    {
      return name;
    }

    public void Display(int depth)
    {
      StructuralExampleUnitTests.OutputHelper.WriteLine(new string('-', depth) + name);
      foreach (var component in children)
      {
        component.Display(depth + 2);
      }
    }

    internal override void Add(IComponent component)
    {
      children.Add(component);
    }

    internal override void Remove(IComponent component)
    {
      children.Remove(component);
    }

    public int Count()
    {
      return this.children.Count();
    }
  }
}
