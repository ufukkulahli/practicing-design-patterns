using Xunit;

namespace practicing_design_patterns.behavioral.@object.strategy.billing
{
  public class BillingUnitTests
  {
    [Fact]
    public void ApplyNormalBillingToAmount()
    {
      // Arrange
      Billing normal = new Normal();

      // Act
      var price = normal.Apply(new decimal(5));

      // Assert
      Assert.Equal(new decimal(5), price);
    }

    [Fact]
    public void ApplyNormalBillingToCustomer()
    {
      // Arrange
      Billing normal = new Normal();
      var customer = new Customer();
      Beverage beer = new Drink(new Money(new Dollar(5)), normal);
      customer.Consume(beer);

      // Act
      var amount = customer.Pay();

      // Assert
      Assert.Equal(new decimal(5), amount);
    }
  }
}
