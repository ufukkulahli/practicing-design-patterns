namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ModernThemedFactory : FurnitureFactory
  {
    public Chair CreateChair() => new ModernChair();

    public Sofa CreateSofa()
    {
      throw new System.NotImplementedException();
    }

    public Table CreateTable()
    {
      throw new System.NotImplementedException();
    }
  }
}
