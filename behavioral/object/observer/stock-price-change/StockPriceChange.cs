using Xunit;

namespace practicing_design_patterns.behavioral.@object.observer.stock_price_change
{
  public class StockPriceChange
  {
    [Fact]
    public void JoeAndJackDaltonGetNotifiedAboutPriceChange()
    {
      // Arrange
      Investor investorJoe = new Investor("Joe Dalton");
      Investor investorJack = new Investor("Jack Dalton");

      var appleStock = new Stock("Apple", new decimal(100));
      appleStock.AddInvestor(investorJoe);
      appleStock.AddInvestor(investorJack);

      // Act
      appleStock.UpdatePrice(new decimal(101));

      // Assert
      Assert.Equal("Apple stock price just changed to 101", investorJoe.LastStockChangeInfo);
      Assert.Equal("Apple stock price just changed to 101", investorJack.LastStockChangeInfo);
    }
  }
}
