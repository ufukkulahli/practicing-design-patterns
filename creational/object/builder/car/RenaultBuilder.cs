namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class RenaultBuilder : ICarBuilder
  {
    public Car TheBuiltCar()
    {
      return new Car();
    }
  }
}