namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public sealed class HomePage : IWebPage
  {
    public string Content() => "You are viewing home page in default theme which is light";
  }
}
