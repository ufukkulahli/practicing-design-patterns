namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ModernTable : Table
  {
    public override Characteristics characteristics =>
      new Characteristics("Modern table", "Metal", new Size(2,1,1));
    
    public override string ToString() =>
      this.characteristics.ToString();
  }
}
