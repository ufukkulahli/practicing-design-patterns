namespace practicing_design_patterns.creational.@object.builder.house
{
  public sealed class HouseBuilder
  {
    private IMaterial wallMaterial;
    private IMaterial windowMaterial;
    private IMaterial doorMaterial;
    private IMaterial roofMaterial;

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

    public HouseBuilder BuildDoor(IMaterial material)
    {
      this.doorMaterial = material;
      return this;
    }

    public HouseBuilder BuildRoof(IMaterial material)
    {
      this.roofMaterial = material;
      return this;
    }
  }
}