namespace practicing_design_patterns.creational.@object.prototype.robot
{
  public sealed class Robot
  {
    private string name;
    private string purpose;

    public Robot(Robot beCopiedFrom)
    {
      this.name = beCopiedFrom.name;
      this.purpose = beCopiedFrom.purpose;
    }

    public Robot(string name, string purpose)
    {
      this.name = name;
      this.purpose = purpose;
    }

    public void Purpose(string purpose) => this.purpose = purpose;
    public string Purpose() => this.purpose;
    public string Name() => this.name;
    public void Name(string name) => this.name = name;
    public Robot Clone() => new Robot(this);
  }
}