using System;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  class WorkerComponent : IComponent
  {
		readonly string name;
		internal WorkerComponent(string name) => this.name=name;

		public string Name() => this.name;
    public void Display(int depth)
    {
		  StructuralExampleUnitTests.OutputHelper.WriteLine(new String('-', depth) + name);
    }
  }
}
