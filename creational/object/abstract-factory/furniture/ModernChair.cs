namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ModernChair : Chair
  {
    public override Characteristics characteristics =>
      new Characteristics("Modern chair", "Metal", new Size(1,1,1));
    
    public override string ToString() =>
      this.characteristics.ToString();
  }
}
