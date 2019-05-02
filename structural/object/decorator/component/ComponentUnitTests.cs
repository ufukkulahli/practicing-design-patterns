using Xunit;
using Xunit.Abstractions;

namespace practicing_design_patterns.structural.@object.decorator.component
{
  public class ComponentUnitTests
  {
    public static ITestOutputHelper OutputHelper;
    public ComponentUnitTests(ITestOutputHelper outputHelper)
      =>OutputHelper=outputHelper;

    [Fact]
    public void ShouldCreateComponentWithDecorators()
    {
      // Arrange
      var component =
        new ScrollDecorator(new BorderDecorator(new TextboxComponent(20,5)));

      // Act
      component.Draw();

      // Assert
      Assert.IsType<BorderDecorator>(component.component);
    }
  }
}
