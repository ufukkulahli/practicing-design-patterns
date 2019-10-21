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

    [Fact]
    public void ApplyNormalAndHappyHourBillingToCustomer()
    {
      // Arrange
      var customer = new Customer();
      Billing normal = new Normal();
      Beverage beer = new Drink(new Money(new Dollar(5)), normal);
      customer.Consume(beer);

      Billing happyHour = new HappyHour();
      Beverage beer2 = new Drink(new Money(new Dollar(5)), happyHour);
      customer.Consume(beer2);

      // Act
      var amount = customer.Pay();

      // Assert
      Assert.Equal(new decimal(7.5), amount);
    }

    [Fact]
    public void ApplyHappyHourBillingToCustomer()
    {
      // Arrange
      var customer = new Customer();
      Billing happyHour = new HappyHour();
      Beverage beer1 = new Drink(new Money(new Dollar(5)), happyHour);
      Beverage beer2 = new Drink(new Money(new Dollar(5)), happyHour);
      customer.Consume(beer1);
      customer.Consume(beer2);

      // Act
      var amount = customer.Pay();

      // Assert
      Assert.Equal(new decimal(5), amount);
    }
  }
}
