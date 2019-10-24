using practicing_design_patterns.behavioral.@object.strategy.billing;
using Xunit;

namespace practicing_design_patterns
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
