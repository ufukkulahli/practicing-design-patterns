using Xunit;

namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public class BillingUnitTests
  {
    [Fact]
    public void ApplyNormalBillingToCustomer()
    {
      // Arrange
      Billing normal = new Normal();

      // Act
      var price = normal.Apply(new decimal(5));

      // Assert
      Assert.Equal(new decimal(5), price);
    }
  }
}
