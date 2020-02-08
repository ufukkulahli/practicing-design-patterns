namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class MotherBoard : IMotherboard
  {
    private string info;
    public MotherBoard(string info) => this.info = info;
    public string Info() => this.info;
  }
}