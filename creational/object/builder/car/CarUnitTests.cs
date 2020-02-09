using System;
using Xunit;

namespace practicing_design_patterns.creational.@object.builder.car
{
  public class CarUnitTests
  {
    [Fact]
    public void BuildsRegularCar()
    {
      // Arrange
      var renaultBuilder = new RenaultBuilder();
      var regularCarBuildDirector = new RegularCarBuildDirector(renaultBuilder);

      // Act
      // TODO

      // Assert
      Assert.Throws<NotImplementedException>(() => regularCarBuildDirector.Construct());
      Assert.Throws<NotImplementedException>(() => renaultBuilder.TheBuiltCar());
    }
  }
}