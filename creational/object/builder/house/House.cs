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

    public string MadeFrom() => $"{wall.ToString()} {window.ToString()} {door.ToString()} {roof.ToString()}";

    private sealed class Wall
    {
      private IMaterial wallMaterial;
      public Wall(IMaterial wallMaterial) => this.wallMaterial = wallMaterial;
      public override string ToString() => $"Wall is {this.wallMaterial.Definition}.";
    }

    private sealed class Window
    {
      private IMaterial windowMaterial;
      public Window(IMaterial windowMaterial) => this.windowMaterial = windowMaterial;
      public override string ToString() => $"Window is {this.windowMaterial.Definition}.";
    }

    private sealed class Door
    {
      private IMaterial doorMaterial;
      public Door(IMaterial doorMaterial) => this.doorMaterial = doorMaterial;
      public override string ToString() => $"Door is {this.doorMaterial.Definition}.";
    }

    private sealed class Roof
    {
      private IMaterial roofMaterial;
      public Roof(IMaterial roofMaterial) => this.roofMaterial = roofMaterial;
      public override string ToString() => $"Roof is {this.roofMaterial.Definition}.";
    }
  }
}