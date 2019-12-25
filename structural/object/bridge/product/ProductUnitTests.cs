using Xunit;

namespace practicing_design_patterns.structural.@object.bridge.product
{
  public class ProductUnitTests
  {
    [Fact]
    public void ChangesTvsStateToOnState()
    {
      // Arrange
      IState on = new OnState();
      Product tv = new Tv(on);

      // Act
      var theStateOfTv = tv.ChangeState();

      // Assert
      Assert.Equal("Current device's state is ON now.", theStateOfTv);
    }

    [Fact]
    public void TvsDefaultStateIsOff()
    {
      // Arrange
      Product tv = new Tv();

      // Act
      var theStateOfTv = tv.ChangeState();

      // Assert
      Assert.Equal("Current device's state is OFF now.", theStateOfTv);
    }
  }
}
