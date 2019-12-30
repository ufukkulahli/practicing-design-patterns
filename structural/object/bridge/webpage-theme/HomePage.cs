namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public sealed class HomePage : WebPage
  {
    public HomePage() : base(new Theme()){}
    public HomePage(Theme theme) : base(theme) {}
    public override string Content() =>
      $"You are viewing home page in default theme which is: {base.defaultTheme}";
  }
}
