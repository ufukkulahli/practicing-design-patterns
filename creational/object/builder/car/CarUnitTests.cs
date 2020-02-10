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
      var renault = renaultBuilder.TheBuiltCar();

      // Assert
      Assert.Throws<NotImplementedException>(() => regularCarBuildDirector.Construct());
      Assert.NotNull(renault);
    }
  }
}