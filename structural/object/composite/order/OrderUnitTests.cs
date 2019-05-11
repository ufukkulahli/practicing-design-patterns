using Xunit;

namespace practicing_design_patterns.structural.@object.composite.order
{
  public class OrderUnitTests
  {
    [Fact]
    public void AssertTotalPriceTrue()
    {
      // ARRANGE
      var smalliPhoneBox = new Box("smalliPhoneBox");
      smalliPhoneBox.AddProduct(new Product(500, "iPhone7"));

      var smallPixelBox = new Box("smallPixelBox");
      smallPixelBox.AddProduct(new Product(500, "Pixel"));

      var midBox = new Box(3, "midBox");
      midBox.AddProduct(smalliPhoneBox);
      midBox.AddProduct(smallPixelBox);

      var bigBox = new Box(5, "bigBox");
      bigBox.AddProduct(midBox);
      bigBox.AddProduct(new Product(100, "Printer"));

      // ACT
      var totalPrice = bigBox.Price();

      // ASSERT
      Assert.Equal(1108, totalPrice);
    }
  }
}
