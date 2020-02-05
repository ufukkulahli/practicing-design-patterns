namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMRam : IRam
  {
    private string size;
    public OEMRam(string size) => this.size = size;
  }
}