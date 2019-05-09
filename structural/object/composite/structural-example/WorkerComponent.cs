namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  internal class WorkerComponent : IComponent
  {
    private readonly string name;

    internal WorkerComponent(string name)
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
    }
  }
}