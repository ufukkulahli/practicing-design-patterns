using Xunit;

namespace practicing_design_patterns.creational.@class.factory_method.dessert
{
  public class DessertUnitTests
  {
    [Fact]
    public void TiramisuIsServedByTheHelpOfTiramisuFactory()
    {
      // ARRANGE
      var tiramisuFactory = new TiramisuFactory();

      // ACT
      var tiramisu = tiramisuFactory.Order();

      // ASSERT
      Assert.Equal("Here is the Tiramisu", tiramisu.Serve());
    }

    [Fact]
    public void CheeseCakeIsServedByTheHelpOfCheeseCakeFactory()
    {
      // ARRANGE
      var cheeseCakeFactory = new CheeseCakeFactory();

      // ACT
      var cheeseCake = cheeseCakeFactory.Order();

      // ASSERT
      Assert.Equal("Here is the CheeseCake", cheeseCake.Serve());
    }
  }
}
