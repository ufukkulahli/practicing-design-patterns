namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ClassicSofa : Sofa
  {
    public override Characteristics characteristics =>
      new Characteristics("Classic sofa", "Wooden", new Size(2, 1, 1));

    public override string ToString() =>
      this.characteristics.ToString();
  }
}
