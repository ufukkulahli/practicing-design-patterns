namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public sealed class AboutPage : WebPage
  {
    public AboutPage() : base(new Theme()) { }
    public AboutPage(Theme theme) : base(theme) { }
    public override string Content() =>
      $"You are viewing about page in default theme which is: {base.defaultTheme}";
  }
}
