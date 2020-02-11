namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class RegularCarBuildDirector
  {
    private readonly ICarBuilder carBuilder;
    public RegularCarBuildDirector(ICarBuilder carBuilder) => this.carBuilder = carBuilder;

    public void Construct()
    {
      this.carBuilder.Color("Black");
      this.carBuilder.Doors(4);
    }
  }
}