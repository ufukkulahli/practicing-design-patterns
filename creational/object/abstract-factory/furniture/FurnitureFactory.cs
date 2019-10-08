namespace practicing_design_patterns.creational.@object.abstract_factory.furniture
{
  public interface FurnitureFactory
  {
    Chair CreateChair();
    Table CreateTable();
    Sofa CreateSofa();
  }
}
