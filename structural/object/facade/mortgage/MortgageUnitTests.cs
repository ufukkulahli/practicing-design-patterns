using practicing_design_patterns.behavioral.@object.strategy.billing;
using Xunit;

namespace practicing_design_patterns.structural.@object.facade.mortgage
{
  public class MortgageUnitTests
  {
    [Fact]
    public void CustomerJohnIsEligibleForMortgage()
    {
      // Arrange
      var mortgageSystem = new Mortgage();
      var john = new Customer("John Doe");

      // Act
      var eligible = mortgageSystem.IsEligibleFor(john, new Dollar(new decimal(125000)));

      // Assert
      Assert.True(eligible);
    }
  }
}
