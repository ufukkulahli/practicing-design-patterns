using System;

namespace practicing_design_patterns.creational.@object.builder.house
{
  public sealed class HouseBuilder
  {
    private IMaterial wallMaterial;
    private IMaterial windowMaterial;
    private IMaterial doorMaterial;
    private IMaterial roofMaterial;

    public HouseBuilder Walls(IMaterial material)
    {
      this.wallMaterial = material;
      return this;
    }

    public HouseBuilder Windows(IMaterial material)
    {
      this.windowMaterial = material;
      return this;
    }

    public HouseBuilder Door(IMaterial material)
    {
      this.doorMaterial = material;
      return this;
    }

    public HouseBuilder Roof(IMaterial material)
    {
      this.roofMaterial = material;
      return this;
    }

    public House Build()
    {
      throw new NotImplementedException();
    }
  }
}