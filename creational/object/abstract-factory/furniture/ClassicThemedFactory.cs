namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public sealed class ClassicThemedFactory : FurnitureFactory
  {
    public Chair Create() => new ClassicChair();
  }
}
