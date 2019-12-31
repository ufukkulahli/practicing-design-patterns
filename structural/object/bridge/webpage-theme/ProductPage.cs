namespace practicing_design_patterns.structural.@object.bridge.webpage_theme
{
  public sealed class ProductPage : WebPage
  {
    public ProductPage(Theme theme) : base(theme) {}
    public override string Content() =>
      $"You are viewing product page in default theme which is: {base.defaultTheme}";
  }
}
