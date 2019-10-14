using Xunit;

namespace practicing_design_patterns.behavioral.@object.strategy.route
{
  public class RouteUnitTests
  {
    [Fact]
    public void RouteByCar()
    {
      // Arrange
      Route road = new RoadRoute();

      // Act
      var route = road.Start
          (new Coordinate("36.8884112", "30.7065862"), new Coordinate("36.893910", "30.705321"));

      Assert.Equal("Road route for: 36.8884112, 30.7065862-36.893910, 30.705321", route);
    }
  }
}
