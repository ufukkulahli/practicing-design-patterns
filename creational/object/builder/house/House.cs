namespace practicing_design_patterns.creational.@object.builder.house
{
  public sealed class House
  {
    private readonly Wall wall;
    private readonly Window window;
    private readonly Door door;
    private readonly Roof roof;

    public House
    (
      IMaterial wallMaterial,
      IMaterial windowMaterial,
      IMaterial doorMaterial,
      IMaterial roofMaterial
    )
    {
      this.wall = new Wall(wallMaterial);
      this.window = new Window(windowMaterial);
      this.door = new Door(doorMaterial);
      this.roof = new Roof(roofMaterial);
    }

    private sealed class Wall
    {
      private IMaterial wallMaterial;
      public Wall(IMaterial wallMaterial) => this.wallMaterial = wallMaterial;
    }

    private sealed class Window
    {
      private IMaterial windowMaterial;
      public Window(IMaterial windowMaterial) => this.windowMaterial = windowMaterial;
    }

    private sealed class Door
    {
      private IMaterial doorMaterial;
      public Door(IMaterial doorMaterial) => this.doorMaterial = doorMaterial;
    }

    private sealed class Roof
    {
      private IMaterial roofMaterial;
      public Roof(IMaterial roofMaterial) => this.roofMaterial = roofMaterial;
    }
  }
}