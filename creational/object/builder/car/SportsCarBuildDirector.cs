namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class SportsCarBuildDirector
  {
    private ICarBuilder carBuilder;

    public SportsCarBuildDirector(ICarBuilder carBuilder)
    {
      this.carBuilder = carBuilder;
    }
    public void Construct()
    {
      this.carBuilder.Color("Silver");
      this.carBuilder.Doors(2);
    }
  }
}