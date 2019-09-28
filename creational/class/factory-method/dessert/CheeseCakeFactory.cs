namespace practicing_design_patterns.creational.@class.factory_method.dessert
{
  public sealed class CheeseCakeFactory : DessertFactory
  {
    public override Dessert Order()
    {
      return new CheeseCake();
    }
  }
}
