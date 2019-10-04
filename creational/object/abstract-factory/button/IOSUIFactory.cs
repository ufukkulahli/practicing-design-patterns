namespace practicing_design_patterns.creational.@object.abstract_factory.button
{
  public sealed class IOSUIFactory : UIFactory
  {
    public Button Create() => new IOSButton();
  }
}
