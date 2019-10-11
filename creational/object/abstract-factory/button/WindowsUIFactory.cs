namespace practicing_design_patterns.creational.@object.abstract_factory.button
{
  public sealed class WindowsUIFactory : UIFactory
  {
    public Button Create() => new WindowsButton();
  }
}
