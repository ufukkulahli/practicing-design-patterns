using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.product
{
  public class ProductUnitTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      IState on = new OnState();
      Product tv = new Tv(on);
      // TODO

      // Act

      // Assert

    }
  }
}
