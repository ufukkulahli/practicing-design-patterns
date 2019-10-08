namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ClassicThemedFactory : FurnitureFactory
  {
    public Chair CreateChair() => new ClassicChair();
    public Table CreateTable() => new ClassicTable();
    public Sofa CreateSofa() => new ClassicSofa();
  }
}
