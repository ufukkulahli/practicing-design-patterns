using Xunit;

namespace practicing_design_patterns.structural.@object.facade.waiter
{
  public class WaiterUnitTests
  {
    [Fact]
    public void WaiterServesAColdAppetizer()
    {
      // Arrange
      Waiter waiter = new Waiter();

      // Act
      waiter.ReceiveOrder(new Reckoning("AColdAppetizer"));
      Orders orders = waiter.Serve();

      // Assert
      Assert.Equal("AColdAppetizer", orders.ToString());
    }

    [Fact]
    public void WaiterServesAColdAppetizerAndAHotEntree()
    {
      // Arrange
      Waiter waiter = new Waiter();

      // Act
      waiter.ReceiveOrder(new Reckoning("AColdAppetizer", "AHotEntree"));
      Orders orders = waiter.Serve();

      // Assert
      Assert.Equal("AColdAppetizer,AHotEntree", orders.ToString());
    }

    [Fact]
    public void WaiterServesAColdAppetizerAndAHotEntreeAndAWhiteWine()
    {
      // Arrange
      Waiter waiter = new Waiter();

      // Act
      waiter.ReceiveOrder(new Reckoning("AColdAppetizer", "AHotEntree", "AWhiteWine"));
      Orders orders = waiter.Serve();

      // Assert
      Assert.Equal("AColdAppetizer,AHotEntree,AWhiteWine", orders.ToString());
    }
  }
}
