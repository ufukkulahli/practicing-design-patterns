namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class HDD : IHardDiskDrive
  {
    private string size;
    public HDD(string size) => this.size = size;
    public string Size() => this.size;
  }
}