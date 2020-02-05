namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class OEMRam : IRam
  {
    private string value;
    public OEMRam(string value) => this.value = value;
  }
}