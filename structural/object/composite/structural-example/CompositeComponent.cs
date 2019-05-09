using System;
using System.Collections.Generic;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  class CompositeComponent : Component, IComponent
  {
		private readonly ICollection<IComponent> children = new List<IComponent>();
		readonly string name;
		CompositeComponent(string name) => this.name=name;

		public string Name() => this.name;

    internal override void Add(IComponent component)
		{
		  this.children.Add(component);
		}

    internal override void Remove(IComponent component)
		{
			this.children.Remove(component);
		}

    public void Display(int depth)
    {
		  Console.WriteLine(new String('-', depth) + name);
			foreach(var component in children)
			{
			  component.Display(depth + 2);
			}
    }
  }
}
