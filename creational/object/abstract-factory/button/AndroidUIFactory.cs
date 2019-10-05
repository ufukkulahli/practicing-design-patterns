namespace practicing_design_patterns.creational.@object.abstract_factory.button
{
  internal class AndroidUIFactory : UIFactory
  {
    public Button Create() => new AndroidButton();
  }
}
