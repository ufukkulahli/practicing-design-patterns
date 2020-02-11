namespace practicing_design_patterns.creational.@object.builder.car
{
  public sealed class Car
  {
    private string brand;
    private string color;
    private int doors;

    public Car(string brand, string color, int doors)
    {
      this.brand = brand;
      this.color = color;
      this.doors = doors;
    }

    public int Doors() => this.doors;
    public string Color() => this.color;
    public string Brand() => this.brand;
  }
}