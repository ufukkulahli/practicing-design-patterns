using Xunit;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public class WaiterUnitTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      Waiter waiter = new Waiter();

      // Act
      waiter.ReceiveOrder(new Reckoning("AColdAppetizer", "AHotEntree", "AWhiteWine"));
      Orders orders = waiter.Serve();

      // Assert
      Assert.NotNull(orders);
    }
  }
}
