using Xunit;

namespace practicing_design_patterns.behavioral.@object.command.product_price
{
  public class ProductPriceUnitTests
  {
    [Fact]
    public void IncreasesProductPrice()
    {
      // Arrange
      var phone = new Product("CoolPhone", new decimal(899));
      Command priceIncrease = new PriceIncreaseCommand(phone, 100);

      // Act
      var updatedPrice = new PriceChanges().Apply(priceIncrease);

      // Assert
      Assert.Equal(999, updatedPrice);
    }

    [Fact]
    public void DecreasesProductPrice()
    {
      // Arrange
      var phone = new Product("CoolPhone", new decimal(899));
      Command priceDecrease = new PriceDecreaseCommand(phone, 100);

      // Act
      var updatedPrice = new PriceChanges().Apply(priceDecrease);

      // Assert
      Assert.Equal(799, updatedPrice);
    }

    [Fact]
    public void DecreasePriceFirstThenUndoThatPriceChange()
    {
      // Arrange
      var phone = new Product("CoolPhone", new decimal(899));
      Command priceDecrease = new PriceDecreaseCommand(phone, 100);
      PriceChanges priceChanges = new PriceChanges();
      var updatedPrice = priceChanges.Apply(priceDecrease);
      Assert.Equal(799, updatedPrice);
      Assert.Equal(799, phone.Price());

      // Act
      priceChanges.UndoLast();

      // Assert
      Assert.Equal(899, phone.Price());
    }
  }
}
