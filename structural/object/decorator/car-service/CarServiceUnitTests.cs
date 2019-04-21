using Xunit;

namespace practicing_design_patterns.structural.@object.decorator.carservice
{
  public class CarServiceUnitTests
  {
    [Fact]
    public void TestShouldCalculateCostAs39()
    {
      // ARRANGE
      var basicInspection = new BasicInspection();
      var oilChange = new OilChange(basicInspection);
      var tireRotation = new TireRotation(oilChange);

      // ACT
      var cost = tireRotation.GetCost();

      // ASSERT
      Assert.Equal(39, cost);
    }
  }
}

