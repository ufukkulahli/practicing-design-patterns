namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ClassicTable : Table
  {
    public override Characteristics characteristics =>
      new Characteristics("Classic table", "Wooden", new Size(3,1,1));
    
    public override string ToString() =>
      this.characteristics.ToString();
  }
}
