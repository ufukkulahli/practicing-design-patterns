namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class SportsCarBuildDirector
  {
    private ICarBuilder carBuilder;

    public SportsCarBuildDirector(ICarBuilder carBuilder)
    {
      this.carBuilder = carBuilder;
    }
  }
}