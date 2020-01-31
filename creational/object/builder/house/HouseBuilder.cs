namespace practicing_design_patterns.creational.@object.builder.house
{
  public sealed class HouseBuilder
  {
    private IMaterial wallMaterial;
    private IMaterial windowMaterial;

    public HouseBuilder BuildWalls(IMaterial material)
    {
      this.wallMaterial = material;
      return this;
    }

    public HouseBuilder BuildWindows(IMaterial material)
    {
      this.windowMaterial = material;
      return this;
    }
  }
}