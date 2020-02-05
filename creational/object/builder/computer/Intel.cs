namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class Intel : ICPU
  {
    private string model;
    public Intel(string model) => this.model = model;
  }
}