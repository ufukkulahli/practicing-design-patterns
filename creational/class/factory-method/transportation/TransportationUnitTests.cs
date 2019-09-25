using Xunit;

namespace practicing_design_patterns.creational.@class.factory_method.transportation
{
  public class TransportationUnitTests
  {
    [Fact]
    public void TruckFactoryCreatesTypeOfTruckTransport()
    {
      // ARRANGE
      TransportFactory truckFactory = new TruckFactory();

      // ACT
      Transport truck = truckFactory.CreateTransportationVehicle();

      // ASSERT
      Assert.Equal("Deliver goods via the <truck>", truck.Deliver());
    }
  }
}
