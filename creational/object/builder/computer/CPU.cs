namespace practicing_design_patterns.creational.@object.builder.computer
{
  public sealed class CPU : ICPU
  {
    private string model;
    public CPU(string model) => this.model = model;
  }
}