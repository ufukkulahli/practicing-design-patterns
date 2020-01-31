namespace practicing_design_patterns.creational.@object.builder.house
{
  public sealed class HouseBuilder
  {
    private IMaterial material;

    public HouseBuilder BuildWalls(IMaterial material)
    {
      this.material = material;
      return this;
    }
  }
}