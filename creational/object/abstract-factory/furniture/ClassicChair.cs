namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  internal class ClassicChair : Chair
  {
    public override Characteristics characteristics =>
      new Characteristics("Classic chair", "Wooden", new Size(1,1,1));
    
    public override string ToString() =>
      this.characteristics.ToString();
  }
}
