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
      regularCarBuildDirector.Construct();
      var renault = renaultBuilder.TheBuiltCar();

      // Assert
      Assert.NotNull(renault);
      Assert.Equal(4, renault.Doors());
      Assert.Equal("Black", renault.Color());
      Assert.Equal("Renault", renault.Brand());
    }
  }
}