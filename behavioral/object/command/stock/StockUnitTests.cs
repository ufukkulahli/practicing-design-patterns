using Xunit;

namespace practicing_design_patterns.behavioral.@object.command.stock
{
  public class StockUnitTests
  {
    [Fact]
    public void BuysStock()
    {
      // Arrange
      var stock = new Stock();
      Order buyStockOrder = new BuyStockOrder(stock);
      var agent = new Agent();

      // Act
      var buyOrderResult = agent.PlaceOrder(buyStockOrder);

      // Assert
      Assert.True(buyOrderResult);
    }

    [Fact]
    public void SellsStock()
    {
      // TODO
      // Arrange

      // Act

      // Assert
    }
  }
}
