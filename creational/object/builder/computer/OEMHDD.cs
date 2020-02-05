namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMHDD : IHardDiskDrive
  {
    private string size;
    public OEMHDD(string size) => this.size = size;
  }
}