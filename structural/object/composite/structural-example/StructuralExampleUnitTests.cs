using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.structural.@object.composite.structural_example
{
  public class StructuralExampleUnitTests
  {
    public StructuralExampleUnitTests(ITestOutputHelper outputHelper)
    {
      OutputHelper = outputHelper;
    }

    public static ITestOutputHelper OutputHelper;

    [Fact]
    public void ShouldPrintRecursivelyAllCompositeAndWorkerComponents()
    {
      // ARRANGE
      var compositeComponent = new CompositeComponent("root component");
      compositeComponent.Add(new WorkerComponent("worker component 1"));
      compositeComponent.Add(new WorkerComponent("worker component 2"));

      var compositeComponent2 = new CompositeComponent("root component 2");
      compositeComponent2.Add(new WorkerComponent("worker component 1 of root component 2"));
      compositeComponent2.Add(new WorkerComponent("worker component 2 of root component 2"));

      compositeComponent.Add(compositeComponent2);
      compositeComponent.Add(new WorkerComponent("worker component in the root"));

      // ACT
      compositeComponent.Display(1);

      // ASSERT
      Assert.Equal(4, compositeComponent.Count());
    }
  }
}
