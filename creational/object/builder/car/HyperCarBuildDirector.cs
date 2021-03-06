namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class HyperCarBuildDirector
  {
    private ICarBuilder carBuilder;
    public HyperCarBuildDirector(ICarBuilder carBuilder) => this.carBuilder = carBuilder;
    public void Construct()
    {
      this.carBuilder.Color("Red");
      this.carBuilder.Doors(2);
    }
  }
}