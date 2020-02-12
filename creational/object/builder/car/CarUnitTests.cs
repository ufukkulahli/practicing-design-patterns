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

    [Fact]
    public void BuildsSportsCar()
    {
      // Arrange
      var porscheBuilder = new PorscheBuilder();
      var sportsCarBuildDirector = new SportsCarBuildDirector(porscheBuilder);

      // Act
      sportsCarBuildDirector.Construct();
      var porsche = porscheBuilder.TheBuiltCar();

      // Assert
      Assert.NotNull(porsche);
      Assert.Equal(2, porsche.Doors());
      Assert.Equal("Silver", porsche.Color());
      Assert.Equal("Porsche", porsche.Brand());
    }
  }
}