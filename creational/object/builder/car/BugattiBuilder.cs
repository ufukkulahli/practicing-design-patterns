namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class BugattiBuilder : ICarBuilder
  {
    private string color;
    private int doors;
    public void Color(string value) => this.color = value;
    public void Doors(int value) => this.doors = value;
    public Car TheBuiltCar() => new Car("Bugatti", this.color, this.doors);
  }
}