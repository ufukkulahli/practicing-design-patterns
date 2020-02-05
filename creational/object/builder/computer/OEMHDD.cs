namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMHDD : IHardDiskDrive
  {
    private string value;
    public OEMHDD(string value) => this.value = value;
  }
}